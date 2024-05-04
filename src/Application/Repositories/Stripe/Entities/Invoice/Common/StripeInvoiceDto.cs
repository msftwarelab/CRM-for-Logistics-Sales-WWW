namespace Application.Repositories.Stripe.Entities.Invoice.Common
{
    public class StripeInvoiceDto
    {
        public string StripeInvoiceId { get; set; }
        public string? FirstFreightInvoiceId { get; set; }
        public bool IsPaid { get; set; }
        public bool IsPaidOutOfBand { get; set; }

        /// <summary>
        /// The status of the invoice, one of <c>draft</c>, <c>open</c>, <c>paid</c>,
        /// <c>uncollectible</c>, or <c>void</c>. <a
        /// href="https://stripe.com/docs/billing/invoices/workflow#workflow-overview">Learn
        /// more</a>.
        /// One of: <c>draft</c>, <c>open</c>, <c>paid</c>, <c>uncollectible</c>, or <c>void</c>.
        /// </summary>
        public string Status { get; set; }
        public string HostedInvoiceUrl { get; set; }
    }
}
