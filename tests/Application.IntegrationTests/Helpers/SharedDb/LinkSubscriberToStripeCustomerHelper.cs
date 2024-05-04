using Domain.Entities.Shared;

namespace Application.IntegrationTests.Helpers.SharedDb
{
    public static class LinkSubscriberToStripeCustomerHelper
    {
        public static LinkSubscriberToStripeCustomer Create(int subscriberId, string? stripeCustomerId = null)
        {
            return new LinkSubscriberToStripeCustomer
            {
                SubscriberId = subscriberId,
                StripeCustomerId = stripeCustomerId
            };
        }
    }
}
