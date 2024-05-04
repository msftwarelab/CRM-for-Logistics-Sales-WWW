using Application.Stripe.Invoice.Commands.Create;
using FluentValidation;

namespace Application.Stripe.Customer.Commands.Create
{
    public class AddStripeInvoiceCommandValidator : AbstractValidator<AddStripeInvoiceCommand>
    {
        public AddStripeInvoiceCommandValidator()
        {
            RequiredFields();
        }

        private void RequiredFields()
        {
            RuleFor(x => x)
                .NotNull();

            RuleFor(x => x.CostInCents)
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.FirstFreightInvoiceId)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.SubscriberId)
                .GreaterThanOrEqualTo(1);

            // If the due date is in the past, Stripe will reject the operation
            RuleFor(x => x.DueDateInUtc)
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.UtcNow.AddSeconds(1));
        }
    }
}
