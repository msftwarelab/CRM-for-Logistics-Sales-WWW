using Application.Repositories.Stripe.Entities.Subscription.Common;

namespace Application.Repositories.Stripe.Entities.Subscription.List
{
    public class ListStripeSubscriptionResponse
    {
        public ListStripeSubscriptionResponse()
        {
            StripeSubscriptionDtos = new();
        }

        public List<StripeSubscriptionDto> StripeSubscriptionDtos { get; }
    }
}
