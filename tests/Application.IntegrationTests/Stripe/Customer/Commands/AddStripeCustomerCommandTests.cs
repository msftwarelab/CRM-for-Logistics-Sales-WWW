using Application.Common;
using Application.Common.Exceptions;
using Application.IntegrationTests.Base;
using Application.IntegrationTests.Helpers.SharedDb;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Customer.Create;
using Application.Stripe.Customer.Commands.Create;
using Domain.Entities.Shared;
using Domain.Enums;
using FluentAssertions;
using Moq;
using Stripe;

namespace Application.IntegrationTests.Stripe.Customer.Commands
{
    public class AddStripeCustomerCommandTests : BaseTestFixture
    {
        public AddStripeCustomerCommandTests(IntegrationTestBaseFixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task AddStripeCustomerCommand_WithEmptyCommand_FailsValidation()
        {
            AddStripeCustomerCommand command = new()
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest()
            };

            await FluentActions.Invoking(() =>
                SendAsync(command)).Should().ThrowAsync<ValidationException>();
        }

        [Fact]
        public async Task AddStripeCustomerCommand_HappyPath()
        {
            Mock<IStripeApiCustomerService> stripeService = new();
            stripeService.Setup(x =>
                x.CreateStripeCustomerAsync(It.IsAny<CreateStripeCustomerRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new CreateStripeCustomerResponse("id"));

            OverrideScopeService(stripeService.Object);

            await AddAsync(SubscriberHelper.Create(1));

            AddStripeCustomerCommand command = new()
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    SubscriberId = 1
                }
            };

            ApplicationResponse<CreateStripeCustomerResponse> response = await SendAsync(command);
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = await FindAsync<LinkSubscriberToStripeCustomer>(1);

            Assert.True(response.IsSuccessful);
            Assert.False(response.ApplicationResult!.IsEmptyResponse);
            Assert.NotNull(response.ApplicationResult.Result);
            Assert.Equal(ResultType.Created, response.ApplicationResult.ResultType);

            Assert.NotNull(linkSubscriberToStripeCustomer);
            Assert.Equal(1, linkSubscriberToStripeCustomer.SubscriberId);
            Assert.Equal("id", linkSubscriberToStripeCustomer.StripeCustomerId);
        }

        [Fact]
        public async Task AddStripeCustomerCommand_SubscriberDoesNotExist()
        {
            Mock<IStripeApiCustomerService> stripeService = new();
            stripeService.Setup(x =>
                x.CreateStripeCustomerAsync(It.IsAny<CreateStripeCustomerRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new CreateStripeCustomerResponse("id"));

            OverrideScopeService(stripeService.Object);

            AddStripeCustomerCommand command = new()
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    SubscriberId = 1
                }
            };

            ApplicationResponse<CreateStripeCustomerResponse> response = await SendAsync(command);
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = await FindAsync<LinkSubscriberToStripeCustomer>(1);

            Assert.False(response.IsSuccessful);
            Assert.NotNull(response.ApplicationError);
            Assert.Equal(ErrorTypeEnum.BadRequest, response.ApplicationError.ErrorTypeEnum);

            Assert.Null(linkSubscriberToStripeCustomer);
        }

        [Fact]
        public async Task AddStripeCustomerCommand_SubscriberToStripeCustomerLinkTableAlreadyHasARecord()
        {
            Mock<IStripeApiCustomerService> stripeService = new();
            stripeService.Setup(x =>
                x.CreateStripeCustomerAsync(It.IsAny<CreateStripeCustomerRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new CreateStripeCustomerResponse("id"));

            OverrideScopeService(stripeService.Object);

            LinkSubscriberToStripeCustomer entity = new()
            {
                SubscriberId = 1
            };
            await AddAsync(entity);

            AddStripeCustomerCommand command = new()
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    SubscriberId = 1
                }
            };

            ApplicationResponse<CreateStripeCustomerResponse> response = await SendAsync(command);
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = await FindAsync<LinkSubscriberToStripeCustomer>(1);

            Assert.False(response.IsSuccessful);
            Assert.NotNull(response.ApplicationError);
            Assert.Equal(ErrorTypeEnum.BadRequest, response.ApplicationError.ErrorTypeEnum);
        }

        [Fact]
        public async Task AddStripeCustomerCommand_StripeThrowsUnknownError()
        {
            Mock<IStripeApiCustomerService> stripeService = new();
            stripeService.Setup(x =>
                x.CreateStripeCustomerAsync(It.IsAny<CreateStripeCustomerRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(() =>
                {
                    StripeException stripeException = new();
                    return new ReposityFailedResponse(stripeException, "unknown error", ErrorTypeEnum.BadRequest);
                });

            OverrideScopeService(stripeService.Object);

            await AddAsync(SubscriberHelper.Create(1));

            AddStripeCustomerCommand command = new()
            {
                CreateStripeCustomerRequest = new CreateStripeCustomerRequest
                {
                    SubscriberId = 1
                }
            };

            ApplicationResponse<CreateStripeCustomerResponse> response = await SendAsync(command);
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = await FindAsync<LinkSubscriberToStripeCustomer>(1);

            Assert.False(response.IsSuccessful);
            Assert.NotNull(response.ApplicationError);
            Assert.Equal(ErrorTypeEnum.BadRequest, response.ApplicationError.ErrorTypeEnum);
            Assert.Equal("unknown error", response.ApplicationError.DomainError.PublicFacingErrorMessage);

            Assert.Null(linkSubscriberToStripeCustomer);
        }
    }
}