using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.Subscription.Add;
using Application.Repositories.Stripe.Entities.Subscription.Common;
using Application.Repositories.Stripe.Entities.Subscription.List;
using Application.Repositories.Stripe.Entities.Subscription.Update;
using Microsoft.Extensions.Logging;
using OneOf;
using Stripe;

namespace Infrastructure.ExternalApi.Stripe
{
    public class StripeApiSubscriptionService : BaseStripeProcessor, IStripeApiSubscriptionService
    {
        private readonly ILogger<StripeApiSubscriptionService> _logger;
        private readonly TokenService _tokenService;
        private readonly SubscriptionService _subscriptionService;
        private readonly SubscriptionItemService _subscriptionItem;
        private readonly PriceService _priceService;
        private readonly IStripeApiCustomerService _stripeApiCustomerService;

        Const constData = new Const();

        public StripeApiSubscriptionService(
            ILogger<StripeApiSubscriptionService> logger,
            TokenService tokenService,
            SubscriptionService subscription,
            SubscriptionItemService subscriptionItem,
            PriceService priceService,
            IStripeApiCustomerService stripeApiCustomerService)
                : base(logger)
        {
            _logger = logger;
            _tokenService = tokenService;
            _subscriptionService = subscription;
            _subscriptionItem = subscriptionItem;
            _priceService = priceService;
            _stripeApiCustomerService = stripeApiCustomerService;
        }

        public async Task<OneOf<AddStripeSubscriptionCardResponse, ReposityQueryNotFoundResponse, ReposityFailedResponse>> AddStripeSubscriptionCardAsync(AddStripeSubscriptionCardRequest subscription, CancellationToken ct)
        {
            return await TryProcessStripeCommand<AddStripeSubscriptionCardResponse, ReposityQueryNotFoundResponse>(async () =>
            {
                TokenCreateOptions tokenOptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = subscription.CreditCard.CardNumber,
                        ExpYear = subscription.CreditCard.ExpirationYear,
                        ExpMonth = subscription.CreditCard.ExpirationMonth,
                        Cvc = subscription.CreditCard.CVC,
                    }
                };
                Token cardToken = await _tokenService.CreateAsync(tokenOptions, null, ct);
                if (cardToken.StripeResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new ReposityFailedResponse();
                }

                return new AddStripeSubscriptionCardResponse(cardToken.Id);
            });
        }

        public async Task<OneOf<AddStripeSubscriptionResponse, ReposityFailedResponse>> AddStripeSubscriptionAsync(AddStripeSubscriptionRequest subscription, CancellationToken ct)
        {
            return await TryProcessStripeCommand<AddStripeSubscriptionResponse>(async () =>
            {
                var Price = constData.YearSubscription;
                if (subscription.SubscriptionType == constData.MONTH)
                {
                    Price = constData.MonthSubscription;
                }

                SubscriptionCreateOptions subscriptionCreateOptions = new()
                {
                    Customer = subscription.CustomerId,
                    Items = new List<SubscriptionItemOptions>
                    {
                        new()
                        {
                            Price = Price,
                            Quantity = subscription.Quantity
                        }
                    }
                };
                Subscription createSubscription = await _subscriptionService.CreateAsync(subscriptionCreateOptions, null, ct);

                if (createSubscription.StripeResponse.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new ReposityFailedResponse();
                }

                return new AddStripeSubscriptionResponse(createSubscription.Id);
            });
        }

        public async Task<OneOf<UpdateStripeSubscriptionResponse, ReposityFailedResponse>> UpdateStripeSubscriptionAsync(UpdateStripeSubscriptionRequest updateStripeSubscriptionRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand((Func<Task<OneOf<UpdateStripeSubscriptionResponse, ReposityFailedResponse>>>)(async () =>
            {
                SubscriptionItemUpdateOptions options = new()
                {
                    Quantity = updateStripeSubscriptionRequest.Quantity,
                    ProrationBehavior = "always_invoice"
                };

                await _subscriptionItem.UpdateAsync(updateStripeSubscriptionRequest.SubscriptionItemId, options);

                return new UpdateStripeSubscriptionResponse();
            }));
        }

        public async Task<OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse>> ListStripeSubscriptionAsync(ListStripeSubscriptionRequest listStripeSubscriptionRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand<ListStripeSubscriptionResponse>(async () =>
            {
                SubscriptionListOptions options = new()
                {
                    Customer = listStripeSubscriptionRequest.StripeCustomerId,
                    Price = listStripeSubscriptionRequest.Price,
                    Status = "all"
                };

                StripeList<Subscription> subscriptions = await _subscriptionService.ListAsync(options, cancellationToken: ct);

                ListStripeSubscriptionResponse result = new();
                var subscriptionDtos = subscriptions.Select(x =>
                {
                    SubscriptionItem? subscriptionItem = x.Items.Data?.FirstOrDefault(x => x.Object == "subscription_item");
                    StripeSubscriptionDto stripeSubscriptionDto = new StripeSubscriptionDto()
                    {
                        Id = x.Id,
                        Status = x.Status,
                        PriceId = subscriptionItem?.Price?.Id,
                        SubscriptionItemId = subscriptionItem?.Id,
                        Quantity = subscriptionItem?.Quantity
                    };
                    return stripeSubscriptionDto;
                });
                result.StripeSubscriptionDtos.AddRange(subscriptionDtos);

                return result;
            });
        }
    }
}
