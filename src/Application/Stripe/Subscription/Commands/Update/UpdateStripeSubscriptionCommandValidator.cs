using FluentValidation;

namespace Application.Stripe.Subscription.Commands.Update
{
    public class UpdateStripeSubscriptionCommandValidator : AbstractValidator<UpdateStripeSubscriptionCommand>
    {
        public UpdateStripeSubscriptionCommandValidator()
        {
            RequiredFields();
        }

        private void RequiredFields()
        {
            RuleFor(x => x)
                .NotNull();

            RuleFor(x => x.SubscriberId)
                .GreaterThanOrEqualTo(1);
        }
    }
}
