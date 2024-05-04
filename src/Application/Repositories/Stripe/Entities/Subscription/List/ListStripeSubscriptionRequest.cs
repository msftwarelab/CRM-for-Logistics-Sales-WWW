namespace Application.Repositories.Stripe.Entities.Subscription.List
{
    public class ListStripeSubscriptionRequest
    {
        public string StripeCustomerId { get; set; }
        public string Price { get; set; }
    }
}
