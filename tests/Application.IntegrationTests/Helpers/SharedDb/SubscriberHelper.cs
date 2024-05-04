using FirstFreightAPI.Entities.Shared;

namespace Application.IntegrationTests.Helpers.SharedDb
{
    public static class SubscriberHelper
    {
        public static Subscriber Create(int id)
        {
            return new Subscriber
            {
                SubscriberId = id,
                CreatedDate = DateTime.Now,
                CompanyName = "Test Company",
                ContactName = "Test Contact",
                CreatedUserName = "Test User",
                CrmAdminEmail = "email@email.com",
                Email = "email@email.com"
            };
        }
    }
}
