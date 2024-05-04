using FluentValidation;

namespace Application.Stripe.PaymentSession.Commands.Create
{
    public class CreateStripePaymentSessionCommandValidator : AbstractValidator<CreateStripePaymentSessionCommand>
    {
        public CreateStripePaymentSessionCommandValidator()
        {
            RequiredFields();
        }

        private void RequiredFields()
        {
            RuleFor(x => x)
                .NotNull();

            RuleFor(x => x.SubscriberId)
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.SuccessUrl)
                .NotNull()
                .Must(x => Uri.TryCreate(x, UriKind.Absolute, out _));

            RuleFor(x => x.CancelUrl)
                .NotNull()
                .Must(x => Uri.TryCreate(x, UriKind.Absolute, out _));

            RuleFor(x => x.PaymentSessionFrequency)
                .IsInEnum();
        }
    }
}
