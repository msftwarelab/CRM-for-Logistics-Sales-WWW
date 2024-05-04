using Application.Common;
using Application.Repositories.Stripe.Entities.Customer.Delete;
using MediatR;
using OneOf;

namespace Application.Stripe.Customer.Commands.Delete
{
    public record DeleteStripeCustomerCommand
        : IRequest<ApplicationResponse<DeleteStripeCustomerResponse>>
    {
        public DeleteStripeCustomerCommand(DeleteStripeCustomerRequest deleteStripeCustomerRequest)
        {
            DeleteStripeCustomerRequest = deleteStripeCustomerRequest;
        }

        public DeleteStripeCustomerRequest DeleteStripeCustomerRequest { get; set; }
    }
}
