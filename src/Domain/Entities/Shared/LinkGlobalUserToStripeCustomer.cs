namespace Domain.Entities.Shared
{
    public class LinkSubscriberToStripeCustomer
    {
        public int SubscriberId { get; set; }
        public string? StripeCustomerId { get; set; }
    }
}
