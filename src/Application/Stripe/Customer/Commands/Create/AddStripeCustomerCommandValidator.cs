using FluentValidation;

namespace Application.Stripe.Customer.Commands.Create
{
    public class AddStripeCustomerCommandValidator : AbstractValidator<AddStripeCustomerCommand>
    {
        public AddStripeCustomerCommandValidator()
        {
            RequiredFields();
            OptionalFields();
        }

        private void RequiredFields()
        {
            RuleFor(x => x.CreateStripeCustomerRequest)
                .NotNull();

            RuleFor(x => x.CreateStripeCustomerRequest.SubscriberId)
                .GreaterThanOrEqualTo(1);
        }

        private void OptionalFields()
        {
            RuleFor(x => x.CreateStripeCustomerRequest.CustomerEmail)
                .EmailAddress()
                .When(x => !string.IsNullOrWhiteSpace(x.CreateStripeCustomerRequest.CustomerEmail));
        }
    }
}
