using Application.Stripe.Invoice.Commands.Pay;
using FluentValidation.TestHelper;

namespace Application.UnitTests.Stripe.Invoice.Commands.Pay
{
    public class GetStripeInvoiceCommandValidatorTests
    {
        private readonly PayStripeInvoiceCommandValidator _validator;

        public GetStripeInvoiceCommandValidatorTests()
        {
            _validator = new PayStripeInvoiceCommandValidator();
        }

        [Fact]
        public async Task GivenNullFirstFreightInvoiceId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new PayStripeInvoiceCommand
            {
                FirstFreightInvoiceId = null
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenEmptyFirstFreightInvoiceId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new PayStripeInvoiceCommand
            {
                FirstFreightInvoiceId = string.Empty
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenFirstFreightInvoiceId_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new PayStripeInvoiceCommand
            {
                FirstFreightInvoiceId = "InvoiceId"
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenNegativeSubscriberId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new PayStripeInvoiceCommand
            {
                SubscriberId = -1
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.SubscriberId);
        }

        public async Task GivenValidSubscriberId_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new PayStripeInvoiceCommand
            {
                SubscriberId = 1 //A valid subscriber ID value
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.SubscriberId);
        }
    }
}
