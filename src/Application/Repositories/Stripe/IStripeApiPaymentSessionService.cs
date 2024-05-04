using Application.Repositories.Common;
using Application.Repositories.Stripe.Entities.PaymentSession.Create;
using Application.Repositories.Stripe.Entities.PaymentSession.Expire;
using Application.Repositories.Stripe.Entities.PaymentSession.List;
using OneOf;

namespace Application.Repositories.Stripe
{
    public interface IStripeApiPaymentSessionService
    {
        Task<OneOf<CreatePaymentSessionResponse, ReposityFailedResponse>> CreatePaymentLink(CreatePaymentSessionRequest createPaymentSessionRequest, CancellationToken ct);
        Task<OneOf<ListPaymentSessionResponse, ReposityFailedResponse>> ListPaymentLinks(ListPaymentSessionRequest listPaymentSessionRequest, CancellationToken ct);
        Task<OneOf<Task, ReposityFailedResponse>> ExpirePaymentLink(ExpirePaymentSessionRequest expirePaymentSessionRequest, CancellationToken ct);
    }
}
