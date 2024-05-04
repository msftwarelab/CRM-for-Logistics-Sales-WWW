namespace Application.Repositories.Stripe.Entities.Invoice.Update
{
    public class UpdateStripeInvoiceResponse
    {
        public UpdateStripeInvoiceResponse(string id, string hostedInvoiceUrl)
        {
            Id = id;
            HostedInvoiceUrl = hostedInvoiceUrl;
        }

        public string Id { get; }
        public string HostedInvoiceUrl { get; }
    }
}
