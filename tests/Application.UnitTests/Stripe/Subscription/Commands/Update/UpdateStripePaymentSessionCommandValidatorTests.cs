using Application.Stripe.Subscription.Commands.Update;
using FluentValidation.TestHelper;

namespace Application.UnitTests.Stripe.Invoice.Pay
{
    public class UpdateStripeSubscriptionCommandValidatorTests
    {
        private readonly UpdateStripeSubscriptionCommandValidator _validator;

        public UpdateStripeSubscriptionCommandValidatorTests()
        {
            _validator = new UpdateStripeSubscriptionCommandValidator();
        }

        [Fact]
        public async Task GivenNegativeSubscriberId_WhenCreateInvoice_ThenReturnsError()
        {
            var command = new UpdateStripeSubscriptionCommand
            {
                SubscriberId = -1
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldHaveValidationErrorFor(x => x.SubscriberId);
        }

        public async Task GivenValidSubscriberId_WhenCreateInvoice_ThenDoesNotReturnError()
        {
            var command = new UpdateStripeSubscriptionCommand
            {
                SubscriberId = 1 //A valid subscriber ID value
            };

            var result = await _validator.TestValidateAsync(command);

            result.ShouldNotHaveValidationErrorFor(x => x.SubscriberId);
        }
    }
}
