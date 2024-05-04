namespace Application.Repositories.Stripe.Entities.Invoice.Add
{
    public class AddStripeInvoiceRequest
    {
        public string StripeCustomerId { get; set; }
        public long CostInCents { get; set; }
        public DateTime? DueDateInUtc { get; set; }
        public string FirstFreightInvoiceId { get; set; }
    }
}
