using FluentValidation;

namespace Application.Stripe.Invoice.Queries.Get
{
    public class GetStripeInvoiceCommandValidator : AbstractValidator<GetStripeInvoiceCommand>
    {
        public GetStripeInvoiceCommandValidator()
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
