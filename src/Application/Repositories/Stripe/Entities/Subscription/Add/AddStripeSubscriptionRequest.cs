namespace Application.Repositories.Stripe.Entities.Subscription.Add
{

    public class AddStripeSubscriptionRequest
    {
        public string CustomerId { get; set; }
        public string SubscriptionType { get; set; }
        public long Quantity { get; set; }
    }
}
