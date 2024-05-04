using Application.Common;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Customer.Delete;
using Application.Repositories.Stripe.Entities.Customer.Update;
using Domain.Enums;
using MediatR;
using OneOf;

namespace Application.Stripe.Customer.Commands.Delete
{
    public class DeleteStripeCustomerCommandHandler :
        BaseHandler,
        IRequestHandler<DeleteStripeCustomerCommand, ApplicationResponse<DeleteStripeCustomerResponse>>
    {
        private readonly IStripeApiCustomerService _stripeApiCustomerService;

        public DeleteStripeCustomerCommandHandler(IStripeApiCustomerService stripeApiCustomerService)
        {
            _stripeApiCustomerService = stripeApiCustomerService;
        }

        public async Task<ApplicationResponse<DeleteStripeCustomerResponse>> Handle(DeleteStripeCustomerCommand request, CancellationToken cancellationToken)
        {
            OneOf<DeleteStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse> deleteStripeCustomerResponse =
                await _stripeApiCustomerService.DeleteStripeCustomerAsync(request.DeleteStripeCustomerRequest, cancellationToken);

            return deleteStripeCustomerResponse.Match(
                result => GetResult(result, ResultType.Ok),
                error => GetError<DeleteStripeCustomerResponse>("An error occured while trying to create a Stripe customer"),
                error => GetError<DeleteStripeCustomerResponse>("An error occured while trying to create a Stripe customer")
            );
        }
    }
}
