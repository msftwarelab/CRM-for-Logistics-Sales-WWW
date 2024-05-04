using Application.Repositories.Stripe.Entities.PaymentSession.Common;

namespace Application.Repositories.Stripe.Entities.PaymentSession.List
{
    public class ListPaymentSessionResponse
    {
        public ListPaymentSessionResponse()
        {
            PaymentSessionDtos = new();
        }

        public List<PaymentSessionDto> PaymentSessionDtos { get; }
    }
}
