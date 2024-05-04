namespace Application.Repositories.Stripe.Entities.Invoice.Add
{
    public class AddStripeInvoiceResponse
    {
        public AddStripeInvoiceResponse(string invoiceId, string hostedInvoiceUrl)
        {
            InvoiceId = invoiceId;
            HostedInvoiceUrl = hostedInvoiceUrl;
        }

        public string InvoiceId { get; }
        public string HostedInvoiceUrl { get; }
    }
}
