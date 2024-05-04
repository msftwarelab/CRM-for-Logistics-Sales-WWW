using Application.Stripe.Customer.Commands.Update;
using Application.Stripe.Invoice.Commands.Update;
using FluentValidation.TestHelper;

namespace Application.UnitTests.Stripe.Invoice.Commands.Update
{
    public class UpdateStripeInvoiceCommandValidatorTests
    {
        private readonly UpdateStripeInvoiceCommandValidator _validator;

        public UpdateStripeInvoiceCommandValidatorTests()
        {
            _validator = new UpdateStripeInvoiceCommandValidator();
        }

        [Fact]
        public async Task GivenEmptyCostInCents_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                CostInCents = 0
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.CostInCents);
        }

        [Fact]
        public async Task GivenValidCostInCents_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                CostInCents = 1000
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.CostInCents);
        }

        [Fact]
        public async Task GivenNullFirstFreightInvoiceId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                FirstFreightInvoiceId = null
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenEmptyFirstFreightInvoiceId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                FirstFreightInvoiceId = string.Empty
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenFirstFreightInvoiceId_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                FirstFreightInvoiceId = "InvoiceId"
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.FirstFreightInvoiceId);
        }

        [Fact]
        public async Task GivenNegativeSubscriberId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                SubscriberId = -1
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.SubscriberId);
        }

        public async Task GivenValidSubscriberId_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                SubscriberId = 1 //A valid subscriber ID value
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.SubscriberId);
        }

        [Fact]
        public async Task GivenDueDateInUtcInThePast_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                DueDateInUtc = DateTime.UtcNow.AddDays(-1)
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.DueDateInUtc);
        }

        [Fact]
        public async Task GivenDueDateInUtcInOneSecondInTheFuture_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                DueDateInUtc = DateTime.UtcNow.AddSeconds(1)
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.DueDateInUtc);
        }

        [Fact]
        public async Task GivenDueDateInUtcInFuture_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new UpdateStripeInvoiceCommand
            {
                DueDateInUtc = DateTime.UtcNow.AddDays(1)
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.DueDateInUtc);
        }
    }
}
