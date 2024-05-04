using Application.Repositories.Stripe.Entities.Customer.Create;
using Application.Stripe.Customer.Commands.Create;
using FluentValidation.TestHelper;

namespace Application.UnitTests.Stripe.Customer.Commands.Add
{
    public class AddStripeCustomerCommandValidatorTests
    {
        private AddStripeCustomerCommandValidator _validator;

        public AddStripeCustomerCommandValidatorTests()
        {
            _validator = new AddStripeCustomerCommandValidator();
        }

        [Fact]
        public void ShouldHaveErrorWhenSubscriberIdIsLessThan1()
        {
            var command = new AddStripeCustomerCommand
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    SubscriberId = 0
                }
            };

            var result = _validator.TestValidate(command);

            result.ShouldHaveValidationErrorFor(x => x.CreateStripeCustomerRequest.SubscriberId);
        }

        [Fact]
        public void ShouldHaveErrorWhenCustomerEmailIsNotValid()
        {
            var command = new AddStripeCustomerCommand
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    CustomerEmail = "invalidemail"
                }
            };

            var result = _validator.TestValidate(command);

            result.ShouldHaveValidationErrorFor(x => x.CreateStripeCustomerRequest.CustomerEmail);
        }

        [Fact]
        public void ShouldNotHaveErrorWhenCustomerEmailIsNull()
        {
            var command = new AddStripeCustomerCommand
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    CustomerEmail = null
                }
            };

            var result = _validator.TestValidate(command);

            result.ShouldNotHaveValidationErrorFor(x => x.CreateStripeCustomerRequest.CustomerEmail);
        }

        [Fact]
        public void ShouldNotHaveErrorsWhenAllFieldsAreValid()
        {
            var command = new AddStripeCustomerCommand
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    SubscriberId = 1,
                    CustomerEmail = "validemail@test.com"
                }
            };

            var result = _validator.TestValidate(command);

            result.ShouldNotHaveAnyValidationErrors();
        }

    }
}
