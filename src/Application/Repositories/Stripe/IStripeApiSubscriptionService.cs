using Application.Repositories.Common;
using Application.Repositories.Stripe.Entities.Subscription.Add;
using Application.Repositories.Stripe.Entities.Subscription.List;
using Application.Repositories.Stripe.Entities.Subscription.Update;
using OneOf;

namespace Application.Repositories.Stripe
{
    public interface IStripeApiSubscriptionService
    {
        Task<OneOf<AddStripeSubscriptionCardResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> AddStripeSubscriptionCardAsync(AddStripeSubscriptionCardRequest subscription, CancellationToken ct);
        Task<OneOf<AddStripeSubscriptionResponse, ReposityFailedResponse>> AddStripeSubscriptionAsync(AddStripeSubscriptionRequest subscription, CancellationToken ct);
        Task<OneOf<UpdateStripeSubscriptionResponse, ReposityFailedResponse>> UpdateStripeSubscriptionAsync(UpdateStripeSubscriptionRequest subscription, CancellationToken ct);
        Task<OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse>> ListStripeSubscriptionAsync(ListStripeSubscriptionRequest listStripeSubscriptionRequest, CancellationToken ct);
    }
}
