using Application.Repositories.Stripe.Entities.PaymentSession.Create;
using Application.Stripe.PaymentSession.Commands.Create;
using FluentValidation.TestHelper;

namespace Application.UnitTests.Stripe.Subscription.Commands.Add
{
    public class CreateStripePaymentSessionCommandValidatorTests
    {
        private readonly CreateStripePaymentSessionCommandValidator _validator;

        public CreateStripePaymentSessionCommandValidatorTests()
        {
            _validator = new CreateStripePaymentSessionCommandValidator();
        }

        [Fact]
        public void SubscriberId_GreaterThanOrEqualTo1_NoValidationError()
        {
            var createStripePaymentSessionCommand = new CreateStripePaymentSessionCommand
            {
                SubscriberId = 1
            };
            var result = _validator.TestValidate(createStripePaymentSessionCommand);

            result.ShouldNotHaveValidationErrorFor(x => x.SubscriberId);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void SubscriberId_LessThan1_ValidationError(int subscriberId)
        {
            var createStripePaymentSessionCommand = new CreateStripePaymentSessionCommand
            {
                SubscriberId = subscriberId
            };
            var result = _validator.TestValidate(createStripePaymentSessionCommand);

            result.ShouldHaveValidationErrorFor(x => x.SubscriberId);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ShouldHaveErrorWhenSubscriberIdIsLessThanOne(int subscriberId)
        {
            var command = new CreateStripePaymentSessionCommand
            {
                SubscriberId = subscriberId
            };

            var result = _validator.TestValidate(command);

            result.ShouldHaveValidationErrorFor(x => x.SubscriberId);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("not a url")]
        public void ShouldHaveErrorWhenSuccessUrlIsNullOrEmptyOrNotUrl(string url)
        {
            var command = new CreateStripePaymentSessionCommand
            {
                SuccessUrl = url
            };

            var result = _validator.TestValidate(command);

            result.ShouldHaveValidationErrorFor(x => x.SuccessUrl);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("not a url")]
        public void ShouldHaveErrorWhenCancelUrlIsNullOrEmptyOrNotUrl(string url)
        {
            var command = new CreateStripePaymentSessionCommand
            {
                CancelUrl = url
            };

            var result = _validator.TestValidate(command);

            result.ShouldHaveValidationErrorFor(x => x.CancelUrl);
        }

        [Theory]
        [InlineData(PaymentSessionFrequency.Yearly)]
        [InlineData(PaymentSessionFrequency.Monthly)]
        public void ShouldNotHaveErrorWhenPaymentSessionFrequencyIsValid(PaymentSessionFrequency frequency)
        {
            var command = new CreateStripePaymentSessionCommand
            {
                PaymentSessionFrequency = frequency
            };

            var result = _validator.TestValidate(command);

            result.ShouldNotHaveValidationErrorFor(x => x.PaymentSessionFrequency);
        }

        [Fact]
        public void ShouldThrowExceptionWhenPaymentSessionFrequencyIsInvalid()
        {
            var command = new CreateStripePaymentSessionCommand
            {
                PaymentSessionFrequency = (PaymentSessionFrequency)99
            };

            var result = _validator.TestValidate(command);

            result.ShouldHaveValidationErrorFor(x => x.PaymentSessionFrequency);
        }
    }
}
