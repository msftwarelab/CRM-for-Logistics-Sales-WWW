namespace Application.Repositories.Stripe.Entities.Subscription.Add
{
    public class AddStripeSubscriptionCardResponse
    {
        public AddStripeSubscriptionCardResponse(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
