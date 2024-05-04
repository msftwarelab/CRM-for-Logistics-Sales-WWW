namespace Application.Repositories.Stripe.Entities.PaymentSession.Create
{
    public class CreatePaymentSessionRequest
    {
        public string Price { get; internal set; }
        public int Quantity { get; internal set; }
        public string SuccessUrl { get; internal set; }
        public string CancelUrl { get; internal set; }
        public string StripeCustomerId { get; internal set; }
    }
}
