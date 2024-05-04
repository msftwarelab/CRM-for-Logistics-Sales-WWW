namespace Application.Repositories.Stripe.Entities.Subscription.Common
{
    public class StripeSubscriptionDto
    {
        public string Status { get; set; }
        public string Id { get; set; }
        public string? PriceId { get; set; }
        public string? SubscriptionItemId { get; set; }
        public long? Quantity { get; set; }
    }
}
