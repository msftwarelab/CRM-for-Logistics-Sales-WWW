using Application.Common;
using Application.Repositories.Stripe.Entities.Customer.Update;
using MediatR;

namespace Application.Stripe.Customer.Commands.Update
{
    public record UpdateStripeCustomerCommand
        : IRequest<ApplicationResponse<UpdateStripeCustomerResponse>>
    {
        public UpdateStripeCustomerCommand(UpdateStripeCustomerRequest updateStripeCustomerRequest)
        {
            UpdateStripeCustomerRequest = updateStripeCustomerRequest;
        }
     
        public UpdateStripeCustomerRequest UpdateStripeCustomerRequest { get; set; }
    }
}
