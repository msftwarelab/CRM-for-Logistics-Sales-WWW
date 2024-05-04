using Application.Common;
using Application.Common.Interfaces;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Invoice.Add;
using Application.Repositories.Stripe.Entities.Invoice.Common;
using Application.Repositories.Stripe.Entities.Invoice.List;
using Domain.Entities.Shared;
using Domain.Enums;
using MediatR;
using OneOf;

namespace Application.Stripe.Invoice.Commands.Create
{
    public class AddStripeInvoiceCommandHandler :
        BaseHandler,
        IRequestHandler<AddStripeInvoiceCommand, ApplicationResponse<AddStripeInvoiceResponse>>
    {
        private readonly IStripeApiInvoiceService _stripeApiInvoiceService;
        private readonly ISharedDbContext _sharedDbContext;

        public AddStripeInvoiceCommandHandler(
            IStripeApiInvoiceService stripeApiInvoiceService,
            ISharedDbContext sharedDbContext)
        {
            _stripeApiInvoiceService = stripeApiInvoiceService;
            _sharedDbContext = sharedDbContext;
        }

        public async Task<ApplicationResponse<AddStripeInvoiceResponse>> Handle(AddStripeInvoiceCommand addStripeInvoiceCommand, CancellationToken cancellationToken)
        {
            // Get linked subscriber
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = GetLinkedStripeCustomer(addStripeInvoiceCommand);
            if (linkSubscriberToStripeCustomer == null)
            {
                return GetError<AddStripeInvoiceResponse>("No Stripe Customer has been created for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Get invoices of this product
            OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices = await ListInvoices(linkSubscriberToStripeCustomer, cancellationToken);
            if (invoices.TryPickT1(out ReposityFailedResponse? result, out ListStripeInvoiceResponse _))
            {
                return GetError<AddStripeInvoiceResponse>(result);
            }

            // Check if there is already an invoice with this id for this Subscriber
            IEnumerable<StripeInvoiceDto> invoicesWithSameFirstFreightInvoiceId = GetMatchingInvoices(addStripeInvoiceCommand, invoices);
            if (invoicesWithSameFirstFreightInvoiceId.Any())
            {
                return GetError<AddStripeInvoiceResponse>("There is already an invoice with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Add invoice
            OneOf<AddStripeInvoiceResponse, ReposityFailedResponse> addStripeInvoiceResponse =
                await AddStripeInvoiceAsync(addStripeInvoiceCommand, linkSubscriberToStripeCustomer, cancellationToken);

            return addStripeInvoiceResponse.Match(
                result => GetResult(result, ResultType.Created),
                error => GetError<AddStripeInvoiceResponse>(error)
            );
        }

        private async Task<OneOf<AddStripeInvoiceResponse, ReposityFailedResponse>> AddStripeInvoiceAsync(AddStripeInvoiceCommand addStripeInvoiceCommand, LinkSubscriberToStripeCustomer linkSubscriberToStripeCustomer, CancellationToken cancellationToken)
        {
            AddStripeInvoiceRequest addStripeInvoiceRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!,
                CostInCents = addStripeInvoiceCommand.CostInCents,
                FirstFreightInvoiceId = addStripeInvoiceCommand.FirstFreightInvoiceId,
                DueDateInUtc = addStripeInvoiceCommand.DueDateInUtc
            };

            return await _stripeApiInvoiceService.AddStripeInvoiceAsync(addStripeInvoiceRequest, cancellationToken);
        }

        private static IEnumerable<StripeInvoiceDto> GetMatchingInvoices(AddStripeInvoiceCommand addStripeInvoiceCommand, OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices) =>
            invoices.AsT0.StripeInvoiceDtos.Where(x =>
                x.FirstFreightInvoiceId == addStripeInvoiceCommand.FirstFreightInvoiceId);

        private async Task<OneOf<ListStripeInvoiceResponse, ReposityFailedResponse>> ListInvoices(LinkSubscriberToStripeCustomer linkSubscriberToStripeCustomer, CancellationToken cancellationToken)
        {
            ListStripeInvoiceRequest listStripeInvoiceRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!
            };

            return await _stripeApiInvoiceService.ListStripeInvoiceAsync(listStripeInvoiceRequest, cancellationToken);
        }

        private LinkSubscriberToStripeCustomer? GetLinkedStripeCustomer(AddStripeInvoiceCommand addStripeInvoiceCommand) =>
            _sharedDbContext.LinkSubscriberToStripeCustomers
               .FirstOrDefault(dbX => dbX.SubscriberId == addStripeInvoiceCommand.SubscriberId);
    }
}
