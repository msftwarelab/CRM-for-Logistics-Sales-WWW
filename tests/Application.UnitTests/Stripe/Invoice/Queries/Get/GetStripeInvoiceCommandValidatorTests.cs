using Application.Stripe.Invoice.Queries.Get;
using FluentValidation.TestHelper;

namespace Application.UnitTests.Stripe.Invoice.Queries.Get
{
    public class GetStripeInvoiceCommandValidatorTests
    {
        private readonly GetStripeInvoiceCommandValidator _validator;

        public GetStripeInvoiceCommandValidatorTests()
        {
            _validator = new GetStripeInvoiceCommandValidator();
        }

        [Fact]
        public async Task GivenNullFirstFreightInvoiceId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new GetStripeInvoiceCommand
            {
                FirstFreightInvoiceId = null
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenEmptyFirstFreightInvoiceId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new GetStripeInvoiceCommand
            {
                FirstFreightInvoiceId = string.Empty
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenFirstFreightInvoiceId_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new GetStripeInvoiceCommand
            {
                FirstFreightInvoiceId = "InvoiceId"
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenNegativeSubscriberId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new GetStripeInvoiceCommand
            {
                SubscriberId = -1
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.SubscriberId);
        }

        public async Task GivenValidSubscriberId_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new GetStripeInvoiceCommand
            {
                SubscriberId = 1 //A valid subscriber ID value
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.SubscriberId);
        }
    }
}
