using Application.Common;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Customer.Update;
using Domain.Enums;
using MediatR;
using OneOf;

namespace Application.Stripe.Customer.Commands.Update
{
    public class UpdateStripeCustomerCommandHandler : 
        BaseHandler,
        IRequestHandler<UpdateStripeCustomerCommand, ApplicationResponse<UpdateStripeCustomerResponse>>
    {
        private readonly IStripeApiCustomerService _stripeApiCustomerService;

        public UpdateStripeCustomerCommandHandler(IStripeApiCustomerService stripeApiCustomerService)
        {
            _stripeApiCustomerService = stripeApiCustomerService;
        }

        public async Task<ApplicationResponse<UpdateStripeCustomerResponse>> Handle(UpdateStripeCustomerCommand request, CancellationToken cancellationToken)
        {
            OneOf<UpdateStripeCustomerResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse> updateStripeCustomerResponse =
                await _stripeApiCustomerService.UpdateStripeCustomerAsync(request.UpdateStripeCustomerRequest, cancellationToken);

            return updateStripeCustomerResponse.Match(
                result => GetResult(result, ResultType.Ok),
                error => GetError<UpdateStripeCustomerResponse>("An error occured while trying to create a Stripe customer"),
                error => GetError<UpdateStripeCustomerResponse>("An error occured while trying to create a Stripe customer")
            );
        }
    }
}
