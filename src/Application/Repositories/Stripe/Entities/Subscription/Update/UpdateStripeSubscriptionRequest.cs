namespace Application.Repositories.Stripe.Entities.Subscription.Update
{
    public class UpdateStripeSubscriptionRequest
    {
        public string SubscriptionId { get; set; }
        public long Quantity { get; set; }
        public string? PriceId { get; set; }
        public string? SubscriptionItemId { get; set; }
    }
}
