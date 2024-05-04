using Application.Common;
using Application.Common.Exceptions;
using Application.IntegrationTests.Base;
using Application.IntegrationTests.Helpers.SharedDb;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Invoice.Add;
using Application.Repositories.Stripe.Entities.Invoice.Common;
using Application.Repositories.Stripe.Entities.Invoice.List;
using Application.Stripe.Invoice.Commands.Create;
using Domain.Entities.Shared;
using Domain.Enums;
using FluentAssertions;
using Moq;

namespace Application.IntegrationTests.Stripe.Invoice.Commands.Add
{
    public class AddStripeInvoiceCommandTests : BaseTestFixture
    {
        public AddStripeInvoiceCommandTests(IntegrationTestBaseFixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task AddStripeInvoiceCommand_WithEmptyCommand_FailsValidation()
        {
            AddStripeInvoiceCommand command = new();

            await FluentActions.Invoking(() =>
                SendAsync(command)).Should().ThrowAsync<ValidationException>();
        }

        [Fact]
        public async Task AddStripeInvoiceCommand_HappyPath()
        {
            Mock<IStripeApiInvoiceService> stripeService = new();
            stripeService.Setup(x =>
                x.AddStripeInvoiceAsync(It.IsAny<AddStripeInvoiceRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new AddStripeInvoiceResponse("id", "url"));
            stripeService.Setup(x =>
                x.ListStripeInvoiceAsync(It.IsAny<ListStripeInvoiceRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ListStripeInvoiceResponse(Array.Empty<StripeInvoiceDto>()));

            OverrideScopeService(stripeService.Object);

            await AddAsync(SubscriberHelper.Create(1));
            await AddAsync(LinkSubscriberToStripeCustomerHelper.Create(1, "id"));

            AddStripeInvoiceCommand command = new()
            {
                SubscriberId = 1,
                CostInCents = 10000,
                DueDateInUtc = DateTime.UtcNow.AddMinutes(1),
                FirstFreightInvoiceId = "id"
            };

            ApplicationResponse<AddStripeInvoiceResponse> response = await SendAsync(command);
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeInvoice = await FindAsync<LinkSubscriberToStripeCustomer>(1);

            Assert.True(response.IsSuccessful);
            Assert.False(response.ApplicationResult!.IsEmptyResponse);
            Assert.NotNull(response.ApplicationResult.Result);
            Assert.Equal(ResultType.Created, response.ApplicationResult.ResultType);
            Assert.Equal("id", response.ApplicationResult.Result.InvoiceId);
            Assert.Equal("url", response.ApplicationResult.Result.HostedInvoiceUrl);

            Assert.NotNull(linkSubscriberToStripeInvoice);
            Assert.Equal(1, linkSubscriberToStripeInvoice.SubscriberId);
            Assert.Equal("id", linkSubscriberToStripeInvoice.StripeCustomerId);
        }
    }
}