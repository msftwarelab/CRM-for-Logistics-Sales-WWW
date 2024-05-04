using Application.Repositories.Stripe.Entities.Invoice.Common;

namespace Application.Repositories.Stripe.Entities.Invoice.List
{
    public class ListStripeInvoiceResponse
    {
        public ListStripeInvoiceResponse(StripeInvoiceDto[] stripeInvoiceDtos)
        {
            StripeInvoiceDtos = stripeInvoiceDtos;
        }

        public StripeInvoiceDto[] StripeInvoiceDtos { get; }
    }
}
