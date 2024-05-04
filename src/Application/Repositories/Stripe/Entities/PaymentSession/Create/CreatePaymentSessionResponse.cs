namespace Application.Repositories.Stripe.Entities.PaymentSession.Create
{
    public class CreatePaymentSessionResponse
    {
        public CreatePaymentSessionResponse(string paymentUrl)
        {
            PaymentUrl = paymentUrl;
        }
        public string PaymentUrl { get; }
    }
}
