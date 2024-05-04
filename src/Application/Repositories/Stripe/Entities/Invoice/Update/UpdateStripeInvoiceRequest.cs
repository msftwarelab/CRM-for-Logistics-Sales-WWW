namespace Application.Repositories.Stripe.Entities.Invoice.Update
{
    public class UpdateStripeInvoiceRequest
    {
        public string StripeCustomerId { get; set; }
        public long CostInCents { get; set; }
        public DateTime? DueDateInUtc { get; set; }
        public string StripeInvoiceId { get; set; }
        public bool IsDraft { get; set; }
    }
}
