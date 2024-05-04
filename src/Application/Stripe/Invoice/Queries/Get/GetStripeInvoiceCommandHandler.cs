using Application.Common;
using Application.Common.Interfaces;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Invoice.Common;
using Application.Repositories.Stripe.Entities.Invoice.List;
using Domain.Entities.Shared;
using Domain.Enums;
using MediatR;
using OneOf;

namespace Application.Stripe.Invoice.Queries.Get
{
    public class GetStripeInvoiceCommandHandler :
        BaseHandler,
        IRequestHandler<GetStripeInvoiceCommand, ApplicationResponse<StripeInvoiceDto>>

    {
        private readonly IStripeApiInvoiceService _stripeApiInvoiceService;
        private readonly ISharedDbContext _sharedDbContext;

        public GetStripeInvoiceCommandHandler(
            IStripeApiInvoiceService stripeApiInvoiceService,
            ISharedDbContext sharedDbContext)
        {
            _stripeApiInvoiceService = stripeApiInvoiceService;
            _sharedDbContext = sharedDbContext;
        }

        public async Task<ApplicationResponse<StripeInvoiceDto>> Handle(GetStripeInvoiceCommand getStripeInvoiceCommand, CancellationToken cancellationToken)
        {
            // Get linked subscriber
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = GetLinkedStripeCustomer(getStripeInvoiceCommand);
            if (linkSubscriberToStripeCustomer == null)
            {
                return GetError<StripeInvoiceDto>("No Stripe Customer has been created for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Get invoices of this product
            OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices = await ListStripeInvoiceAsync(linkSubscriberToStripeCustomer, cancellationToken);
            if (invoices.TryPickT1(out ReposityFailedResponse? result, out ListStripeInvoiceResponse _))
            {
                return GetError<StripeInvoiceDto>(result.ErrorTypeEnumOverride);
            }

            // Filter invoices
            IEnumerable<StripeInvoiceDto> matchingInvoices = FilterInvoices(getStripeInvoiceCommand, invoices);

            int count = matchingInvoices.Count();
            if (count == 0)
            {
                return GetError<StripeInvoiceDto>("There is no invoice with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            if (count > 1)
            {
                return GetError<StripeInvoiceDto>("There is more than one invoices with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            return GetResult(matchingInvoices.First(), ResultType.Ok);
        }

        private static IEnumerable<StripeInvoiceDto> FilterInvoices(GetStripeInvoiceCommand getStripeInvoiceCommand, OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices) =>
            invoices.AsT0.StripeInvoiceDtos.Where(x =>
                x.FirstFreightInvoiceId == getStripeInvoiceCommand.FirstFreightInvoiceId);

        private async Task<OneOf<ListStripeInvoiceResponse, ReposityFailedResponse>> ListStripeInvoiceAsync(LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer, CancellationToken cancellationToken)
        {
            ListStripeInvoiceRequest listStripeInvoiceRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!
            };

            return await _stripeApiInvoiceService.ListStripeInvoiceAsync(listStripeInvoiceRequest, cancellationToken);
        }

        private LinkSubscriberToStripeCustomer? GetLinkedStripeCustomer(GetStripeInvoiceCommand getStripeInvoiceCommand) =>
            _sharedDbContext.LinkSubscriberToStripeCustomers
               .FirstOrDefault(dbX => dbX.SubscriberId == getStripeInvoiceCommand.SubscriberId);
    }
}
