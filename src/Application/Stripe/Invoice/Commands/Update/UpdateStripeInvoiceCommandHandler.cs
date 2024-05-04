using Application.Common;
using Application.Repositories.Common;
using Application.Repositories.Stripe.Entities.Invoice.Update;
using Application.Repositories.Stripe;
using MediatR;
using OneOf;
using Application.Repositories.Stripe.Entities.Customer.Create;
using Domain.Enums;
using Application.Repositories.Stripe.Entities.Invoice.Add;
using Application.Repositories.Stripe.Entities.Invoice.List;
using Application.Common.Interfaces;
using Domain.Entities.Shared;
using Application.Repositories.Stripe.Entities.Invoice.Common;

namespace Application.Stripe.Invoice.Commands.Update
{
    public class UpdateStripeInvoiceCommandHandler :
        BaseHandler,
        IRequestHandler<UpdateStripeInvoiceCommand, ApplicationResponse<UpdateStripeInvoiceResponse>>
    {
        private readonly IStripeApiInvoiceService _stripeApiInvoiceService;
        private readonly ISharedDbContext _sharedDbContext;

        public UpdateStripeInvoiceCommandHandler(
            IStripeApiInvoiceService stripeApiInvoiceService,
            ISharedDbContext sharedDbContext)
        {
            _stripeApiInvoiceService = stripeApiInvoiceService;
            _sharedDbContext = sharedDbContext;
        }

        public async Task<ApplicationResponse<UpdateStripeInvoiceResponse>> Handle(UpdateStripeInvoiceCommand updateStripeInvoiceCommand, CancellationToken cancellationToken)
        {
            // Get linked subscriber
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = GetLinkedStripeCustomer(updateStripeInvoiceCommand);
            if (linkSubscriberToStripeCustomer == null)
            {
                return GetError<UpdateStripeInvoiceResponse>("No Stripe Customer has been created for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Get invoices of this product
            OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices = await ListStripeInvoiceAsync(linkSubscriberToStripeCustomer, cancellationToken);
            if (invoices.TryPickT1(out ReposityFailedResponse? result, out ListStripeInvoiceResponse _))
            {
                return GetError<UpdateStripeInvoiceResponse>(result.ErrorTypeEnumOverride);
            }

            // Filter invoices
            IEnumerable<StripeInvoiceDto> openInvoices = FilterOpenInvoices(updateStripeInvoiceCommand, invoices);
            IEnumerable<StripeInvoiceDto> draftInvoices = FilterDraftInvoices(updateStripeInvoiceCommand, invoices);

            int countOfActiveInvoices = openInvoices.Count();
            if (countOfActiveInvoices == 0)
            {
                return GetError<UpdateStripeInvoiceResponse>("There is no invoice with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            if (countOfActiveInvoices > 1)
            {
                return GetError<UpdateStripeInvoiceResponse>("There is more than one open invoices with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            int countOfDraftInvoices = draftInvoices.Count();
            if (countOfDraftInvoices > 1)
            {
                return GetError<UpdateStripeInvoiceResponse>("There is more than one draft invoices with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Update invoice
            OneOf<UpdateStripeInvoiceResponse, ReposityFailedResponse> updateStripeInvoiceResponse = await UpdateStripeInvoiceAsync(openInvoices, draftInvoices, countOfDraftInvoices, updateStripeInvoiceCommand, linkSubscriberToStripeCustomer, cancellationToken);

            return updateStripeInvoiceResponse.Match(
                result => GetResult(result, ResultType.Ok),
                error => GetError<UpdateStripeInvoiceResponse>(error)
            );
        }

        private async Task<OneOf<UpdateStripeInvoiceResponse, ReposityFailedResponse>> UpdateStripeInvoiceAsync(
            IEnumerable<StripeInvoiceDto> openInvoices,
            IEnumerable<StripeInvoiceDto> draftInvoices,
            int countOfDraftInvoices,
            UpdateStripeInvoiceCommand updateStripeInvoiceCommand,
            LinkSubscriberToStripeCustomer linkSubscriberToStripeCustomer,
            CancellationToken cancellationToken)
        {
            UpdateStripeInvoiceRequest updateStripeInvoiceRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!,
                CostInCents = updateStripeInvoiceCommand.CostInCents,
                DueDateInUtc = updateStripeInvoiceCommand.DueDateInUtc
            };

            if (countOfDraftInvoices == 1)
            {
                updateStripeInvoiceRequest.IsDraft = true;
                updateStripeInvoiceRequest.StripeInvoiceId = draftInvoices.First().StripeInvoiceId;
            }
            else
            {
                updateStripeInvoiceRequest.StripeInvoiceId = openInvoices.First().StripeInvoiceId;
            }

            return await _stripeApiInvoiceService.UpdateStripeInvoiceAsync(updateStripeInvoiceRequest, cancellationToken);
        }

        private static IEnumerable<StripeInvoiceDto> FilterDraftInvoices(UpdateStripeInvoiceCommand updateStripeInvoiceCommand, OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices) =>
            invoices.AsT0.StripeInvoiceDtos.Where(x =>
                x.FirstFreightInvoiceId == updateStripeInvoiceCommand.FirstFreightInvoiceId &&
                x.Status == "draft");

        private static IEnumerable<StripeInvoiceDto> FilterOpenInvoices(UpdateStripeInvoiceCommand updateStripeInvoiceCommand, OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices) =>
            invoices.AsT0.StripeInvoiceDtos.Where(x =>
                x.FirstFreightInvoiceId == updateStripeInvoiceCommand.FirstFreightInvoiceId &&
                x.Status == "open");

        private async Task<OneOf<ListStripeInvoiceResponse, ReposityFailedResponse>> ListStripeInvoiceAsync(LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer, CancellationToken cancellationToken)
        {
            ListStripeInvoiceRequest listStripeInvoiceRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!
            };

            return await _stripeApiInvoiceService.ListStripeInvoiceAsync(listStripeInvoiceRequest, cancellationToken);
        }

        private LinkSubscriberToStripeCustomer? GetLinkedStripeCustomer(UpdateStripeInvoiceCommand updateStripeInvoiceCommand) =>
            _sharedDbContext.LinkSubscriberToStripeCustomers
               .FirstOrDefault(dbX => dbX.SubscriberId == updateStripeInvoiceCommand.SubscriberId);
    }
}
