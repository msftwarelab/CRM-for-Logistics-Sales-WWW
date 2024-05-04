using Application.Common;
using Application.Repositories.Stripe.Entities.Invoice.Pay;
using MediatR;

namespace Application.Stripe.Invoice.Commands.Pay
{
    public class PayStripeInvoiceCommand
        : IRequest<ApplicationResponse<PayStripeInvoiceResponse>>
    {
        public string FirstFreightInvoiceId { get; set; }
        public int SubscriberId { get; set; }
    }
}
