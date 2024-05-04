using Application.Common;
using Application.Repositories.Stripe.Entities.Customer.Create;
using MediatR;

namespace Application.Stripe.Customer.Commands.Create
{
    public class AddStripeCustomerCommand
        : IRequest<ApplicationResponse<CreateStripeCustomerResponse>>
    {
        public AddStripeCustomerCommand()
        {

        }

        public AddStripeCustomerCommand(CreateStripeCustomerRequest createStripeCustomerRequest)
        {
            CreateStripeCustomerRequest = createStripeCustomerRequest;
        }

        public CreateStripeCustomerRequest CreateStripeCustomerRequest { get; set; }
    }
}
