using FluentValidation;

namespace Application.Stripe.Invoice.Commands.Pay
{
    public class PayStripeInvoiceCommandValidator : AbstractValidator<PayStripeInvoiceCommand>
    {
        public PayStripeInvoiceCommandValidator()
        {
            RequiredFields();
        }

        private void RequiredFields()
        {
            RuleFor(x => x)
                .NotNull();

            RuleFor(x => x.FirstFreightInvoiceId)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.SubscriberId)
                .GreaterThanOrEqualTo(1);
        }
    }
}
