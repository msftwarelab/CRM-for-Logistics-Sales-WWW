namespace Application.Common.Settings
{
    public class StripeSettings
    {
        public string SecretKey { get; set; }
        public string SubscriptionMonthlyPriceId { get; set; }
        public string SubscriptionYearlyPriceId { get; set; }
    }
}
