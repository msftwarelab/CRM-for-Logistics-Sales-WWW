using Application.Common;
using Application.Common.Interfaces;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Invoice.Common;
using Application.Repositories.Stripe.Entities.Invoice.List;
using Application.Repositories.Stripe.Entities.Invoice.Pay;
using Application.Stripe.Invoice.Commands.Create;
using Domain.Entities.Shared;
using Domain.Enums;
using FluentValidation;
using MediatR;
using OneOf;

namespace Application.Stripe.Invoice.Commands.Pay
{
    public class PayStripeInvoiceCommandHandler :
        BaseHandler,
        IRequestHandler<PayStripeInvoiceCommand, ApplicationResponse<PayStripeInvoiceResponse>>
    {
        private readonly IStripeApiInvoiceService _stripeApiInvoiceService;
        private readonly ISharedDbContext _sharedDbContext;

        public PayStripeInvoiceCommandHandler(
            IStripeApiInvoiceService stripeApiInvoiceService,
            ISharedDbContext sharedDbContext)
        {
            _stripeApiInvoiceService = stripeApiInvoiceService;
            _sharedDbContext = sharedDbContext;
        }

        public async Task<ApplicationResponse<PayStripeInvoiceResponse>> Handle(PayStripeInvoiceCommand payStripeInvoiceCommand, CancellationToken cancellationToken)
        {
            // Get linked subscriber
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = GetLinkedStripeCustomer(payStripeInvoiceCommand);
            if (linkSubscriberToStripeCustomer == null)
            {
                return GetError<PayStripeInvoiceResponse>("No Stripe Customer has been created for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Get invoices of this user
            OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices = await ListStripeInvoiceAsync(linkSubscriberToStripeCustomer, cancellationToken);
            if (invoices.TryPickT1(out ReposityFailedResponse? result, out ListStripeInvoiceResponse _))
            {
                return GetError<PayStripeInvoiceResponse>(result.ErrorTypeEnumOverride);
            }

            // Check if there is already an open invoice with this id for this Subscriber
            IEnumerable<StripeInvoiceDto> activeInvoices = FilterMatchingAndOpenInvoice(payStripeInvoiceCommand, invoices);
            int countOfActiveInvoices = activeInvoices.Count();
            if (countOfActiveInvoices == 0)
            {
                return GetError<PayStripeInvoiceResponse>("There is no invoice with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            if (countOfActiveInvoices > 1)
            {
                return GetError<PayStripeInvoiceResponse>("There is more than one open invoices with this id for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Pay invoice
            OneOf<PayStripeInvoiceResponse, ReposityFailedResponse> payStripeInvoiceResponse = await PayStripeInvoiceAsync(activeInvoices, cancellationToken);

            return payStripeInvoiceResponse.Match(
                result => GetResult(result, ResultType.Ok, true),
                error => GetError<PayStripeInvoiceResponse>(error)
            );
        }

        private async Task<OneOf<PayStripeInvoiceResponse, ReposityFailedResponse>> PayStripeInvoiceAsync(IEnumerable<StripeInvoiceDto> activeInvoices, CancellationToken cancellationToken)
        {
            PayStripeInvoiceRequest payStripeInvoiceRequest = new()
            {
                InvoiceId = activeInvoices.First().StripeInvoiceId
            };

            return await _stripeApiInvoiceService.PayStripeInvoiceAsync(payStripeInvoiceRequest, cancellationToken);
        }

        private static IEnumerable<StripeInvoiceDto> FilterMatchingAndOpenInvoice(PayStripeInvoiceCommand payStripeInvoiceCommand, OneOf<ListStripeInvoiceResponse, ReposityFailedResponse> invoices) =>
            invoices.AsT0.StripeInvoiceDtos.Where(x =>
                x.FirstFreightInvoiceId == payStripeInvoiceCommand.FirstFreightInvoiceId &&
                x.Status == "open");

        private async Task<OneOf<ListStripeInvoiceResponse, ReposityFailedResponse>> ListStripeInvoiceAsync(LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer, CancellationToken cancellationToken)
        {
            ListStripeInvoiceRequest listStripeInvoiceRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!
            };

            return await _stripeApiInvoiceService.ListStripeInvoiceAsync(listStripeInvoiceRequest, cancellationToken);
        }

        private LinkSubscriberToStripeCustomer? GetLinkedStripeCustomer(PayStripeInvoiceCommand payStripeInvoiceCommand) =>
            _sharedDbContext.LinkSubscriberToStripeCustomers
               .FirstOrDefault(dbX => dbX.SubscriberId == payStripeInvoiceCommand.SubscriberId);
    }
}
