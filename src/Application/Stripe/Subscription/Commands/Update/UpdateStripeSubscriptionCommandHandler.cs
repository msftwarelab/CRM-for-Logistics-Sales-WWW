using Application.Common;
using Application.Repositories.Common;
using Application.Repositories.Stripe.Entities.Subscription.Update;
using Application.Repositories.Stripe;
using MediatR;
using OneOf;
using Domain.Enums;
using Application.Stripe.PaymentSession.Commands.Create;
using Domain.Entities.Shared;
using Application.Common.Interfaces;
using Application.Common.Settings;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Application.Repositories.Stripe.Entities.Subscription.List;
using Application.Repositories.Stripe.Entities.Subscription.Common;

namespace Application.Stripe.Subscription.Commands.Update
{
    public class UpdateStripeSubscriptionCommandHandler :
        BaseHandler,
        IRequestHandler<UpdateStripeSubscriptionCommand, ApplicationResponse<UpdateStripeSubscriptionResponse>>
    {
        private readonly ILogger<UpdateStripeSubscriptionCommandHandler> _logger;
        private readonly IStripeApiSubscriptionService _stripeApiSubscriptionService;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly StripeSettings _stripeSettings;

        public UpdateStripeSubscriptionCommandHandler(
            ILogger<UpdateStripeSubscriptionCommandHandler> logger,
            IStripeApiSubscriptionService stripeApiSubscriptionService,
            IOptions<StripeSettings> stripeSettings,
            ISharedDbContext sharedDbContext)
        {
            _logger = logger;
            _stripeApiSubscriptionService = stripeApiSubscriptionService;
            _stripeSettings = stripeSettings.Value;
            _sharedDbContext = sharedDbContext;
        }

        public async Task<ApplicationResponse<UpdateStripeSubscriptionResponse>> Handle(UpdateStripeSubscriptionCommand updateStripeSubscriptionCommand, CancellationToken cancellationToken)
        {
            // Get linked subscriber
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = GetLinkedStripeCustomer(updateStripeSubscriptionCommand);
            if (linkSubscriberToStripeCustomer == null)
            {
                return GetError<UpdateStripeSubscriptionResponse>("No Stripe Customer has been created for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Get subscriptions of this product
            OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse> listStripeSubscriptionResponse = await ListSubscriptions(linkSubscriberToStripeCustomer, cancellationToken);
            if (listStripeSubscriptionResponse.TryPickT1(out ReposityFailedResponse? result2, out ListStripeSubscriptionResponse _))
            {
                return GetError<UpdateStripeSubscriptionResponse>(result2!);
            }

            // Filter non cancelled subscriptions
            List<StripeSubscriptionDto> nonCancelledSubscriptions =
                GetNonCancelledSubscriptions(listStripeSubscriptionResponse)
                .ToList();

            if (nonCancelledSubscriptions.Count == 0)
            {
                return GetError<UpdateStripeSubscriptionResponse>("No active subscription for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            if (nonCancelledSubscriptions.Count > 1)
            {
                return GetError<UpdateStripeSubscriptionResponse>("More than one active subscription for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            StripeSubscriptionDto stripeSubscriptionDto = nonCancelledSubscriptions.First();
            if (stripeSubscriptionDto.Quantity == null)
            {
                return GetError<UpdateStripeSubscriptionResponse>("The current quantity for the current active subscription for this Subscriber count not be retrieved", ErrorTypeEnum.BadRequest);
            }

            // Get active users count
            int numberOfActiveGlobalUsers = GetNumberOfActiveUsersForTheSubscriber(updateStripeSubscriptionCommand);
            if (numberOfActiveGlobalUsers == 0)
            {
                return GetError<UpdateStripeSubscriptionResponse>("This subscriber has no active users", ErrorTypeEnum.BadRequest);
            }

            if (stripeSubscriptionDto.Quantity == numberOfActiveGlobalUsers)
            {
                return GetResult<UpdateStripeSubscriptionResponse>(null!, ResultType.NotModified, true);
            }

            // Update subscription
            OneOf<UpdateStripeSubscriptionResponse, ReposityFailedResponse> updateStripeSubscriptionResponse = await UpdateSubscription(stripeSubscriptionDto, numberOfActiveGlobalUsers, cancellationToken);

            return updateStripeSubscriptionResponse.Match(
                result => GetResult(result, ResultType.Ok, true),
                error => GetError<UpdateStripeSubscriptionResponse>(error)
            );
        }

        private async Task<OneOf<UpdateStripeSubscriptionResponse, ReposityFailedResponse>> UpdateSubscription(StripeSubscriptionDto stripeSubscriptionDto, int numberOfActiveGlobalUsers, CancellationToken cancellationToken)
        {
            UpdateStripeSubscriptionRequest stripeSubscriptionRequest = new()
            {
                SubscriptionId = stripeSubscriptionDto.Id,
                Quantity = numberOfActiveGlobalUsers,
                PriceId = stripeSubscriptionDto.PriceId,
                SubscriptionItemId = stripeSubscriptionDto.SubscriptionItemId
            };

            return await _stripeApiSubscriptionService.UpdateStripeSubscriptionAsync(stripeSubscriptionRequest, cancellationToken);
        }

        private LinkSubscriberToStripeCustomer? GetLinkedStripeCustomer(UpdateStripeSubscriptionCommand createStripePaymentSessionCommand) =>
            _sharedDbContext.LinkSubscriberToStripeCustomers
                .FirstOrDefault(dbX => dbX.SubscriberId == createStripePaymentSessionCommand.SubscriberId);

        private async Task<OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse>> ListSubscriptions(LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer, CancellationToken cancellationToken)
        {
            ListStripeSubscriptionRequest listStripeSubscriptionRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!
            };

            return await _stripeApiSubscriptionService.ListStripeSubscriptionAsync(listStripeSubscriptionRequest, cancellationToken);
        }

        private IEnumerable<StripeSubscriptionDto> GetNonCancelledSubscriptions(OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse> listStripeSubscriptionResponse) =>
            listStripeSubscriptionResponse
                .AsT0
                .StripeSubscriptionDtos
                .Where(x =>
                    x.Status != "canceled"
                    && IsPriceKnownSubscription(x));

        private bool IsPriceKnownSubscription(StripeSubscriptionDto x) =>
            x?.PriceId == _stripeSettings.SubscriptionMonthlyPriceId 
            || x?.PriceId == _stripeSettings.SubscriptionYearlyPriceId;

        private int GetNumberOfActiveUsersForTheSubscriber(UpdateStripeSubscriptionCommand createStripePaymentSessionCommand) =>
            _sharedDbContext
                .GlobalUsers
                .Count(x =>
                    x.SubscriberId == createStripePaymentSessionCommand.SubscriberId
                    && !x.Deleted);
    }
}
