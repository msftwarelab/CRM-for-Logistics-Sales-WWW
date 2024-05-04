using Application.Repositories.Stripe.Entities.Subscription.Common;

namespace Application.Repositories.Stripe.Entities.Subscription.Add
{
    public class AddStripeSubscriptionCardRequest
    {
        public StripeCard CreditCard { get; set; }
    }
}
