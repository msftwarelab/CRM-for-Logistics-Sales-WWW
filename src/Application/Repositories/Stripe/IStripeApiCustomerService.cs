using Application.Repositories.Common;
using Application.Repositories.Stripe.Entities.Customer.Create;
using Application.Repositories.Stripe.Entities.Customer.Delete;
using Application.Repositories.Stripe.Entities.Customer.Query;
using Application.Repositories.Stripe.Entities.Customer.Update;
using OneOf;

namespace Application.Repositories.Stripe
{
    public interface IStripeApiCustomerService
    {
        Task<OneOf<QueryStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> SearchStripeCustomerAsync(QueryStripeCustomerRequest queryStripeCustomerRequest, CancellationToken ct);
        Task<OneOf<CreateStripeCustomerResponse, ReposityFailedResponse>> CreateStripeCustomerAsync(CreateStripeCustomerRequest customer, CancellationToken ct);
        Task<OneOf<UpdateStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> UpdateStripeCustomerAsync(UpdateStripeCustomerRequest customer, CancellationToken ct);
        Task<OneOf<DeleteStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> DeleteStripeCustomerAsync(DeleteStripeCustomerRequest customer, CancellationToken ct);
    }
}
