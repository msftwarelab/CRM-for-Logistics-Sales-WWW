using Application.Common;
using Application.Common.Interfaces;
using Application.Common.Settings;
using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.PaymentSession.Common;
using Application.Repositories.Stripe.Entities.PaymentSession.Create;
using Application.Repositories.Stripe.Entities.PaymentSession.Expire;
using Application.Repositories.Stripe.Entities.PaymentSession.List;
using Application.Repositories.Stripe.Entities.Subscription.Common;
using Application.Repositories.Stripe.Entities.Subscription.List;
using Domain.Entities.Shared;
using Domain.Enums;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OneOf;

namespace Application.Stripe.PaymentSession.Commands.Create
{
    public class CreateStripePaymentSessionCommandHandler :
        BaseHandler,
        IRequestHandler<CreateStripePaymentSessionCommand, ApplicationResponse<CreatePaymentSessionResponse>>
    {
        private readonly ILogger<CreateStripePaymentSessionCommandHandler> _logger;
        private readonly IStripeApiPaymentSessionService _sessionService;
        private readonly IStripeApiSubscriptionService _stripeApiSubscriptionService;
        private readonly ISharedDbContext _sharedDbContext;
        private readonly StripeSettings _stripeSettings;

        public CreateStripePaymentSessionCommandHandler(
            ILogger<CreateStripePaymentSessionCommandHandler> logger,
            IStripeApiPaymentSessionService sessionService,
            IStripeApiSubscriptionService stripeApiSubscriptionService,
            IOptions<StripeSettings> stripeSettings,
            ISharedDbContext sharedDbContext)
        {
            _logger = logger;
            _sessionService = sessionService;
            _stripeApiSubscriptionService = stripeApiSubscriptionService;
            _stripeSettings = stripeSettings.Value;
            _sharedDbContext = sharedDbContext;
        }

        public async Task<ApplicationResponse<CreatePaymentSessionResponse>> Handle(CreateStripePaymentSessionCommand createStripePaymentSessionCommand, CancellationToken cancellationToken)
        {
            // Get linked subscriber
            LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer = GetLinkedStripeCustomer(createStripePaymentSessionCommand);
            if (linkSubscriberToStripeCustomer == null)
            {
                return GetError<CreatePaymentSessionResponse>("No Stripe Customer has been created for this Subscriber", ErrorTypeEnum.BadRequest);
            }

            // Get price
            string? price = GetPrice(createStripePaymentSessionCommand);
            if (price == null)
            {
                _logger.LogError("No valid Stripe price to use");
                return GetError<CreatePaymentSessionResponse>(ErrorTypeEnum.Internal);
            }

            // Get payment sessions
            OneOf<ListPaymentSessionResponse, ReposityFailedResponse> listPaymentSessionResponse = await ListPaymentSessions(linkSubscriberToStripeCustomer, cancellationToken);
            if (listPaymentSessionResponse.TryPickT1(out ReposityFailedResponse? result, out ListPaymentSessionResponse _))
            {
                return GetError<CreatePaymentSessionResponse>(result!);
            }

            // Expire active payment sessions
            await ExpireActivePaymentSessions(listPaymentSessionResponse, cancellationToken);

            // Get subscriptions of this product
            OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse> listStripeSubscriptionResponse = await ListSubscriptions(linkSubscriberToStripeCustomer, price, cancellationToken);
            if (listStripeSubscriptionResponse.TryPickT1(out ReposityFailedResponse? result2, out ListStripeSubscriptionResponse _))
            {
                return GetError<CreatePaymentSessionResponse>(result2!);
            }

            // Filter non cancelled subscriptions and ensure there are not active
            IEnumerable<StripeSubscriptionDto> nonCancelledSubscriptions = GetNonCancelledSubscriptions(listStripeSubscriptionResponse);
            if (nonCancelledSubscriptions.Any())
            {
                return GetError<CreatePaymentSessionResponse>("There is a subscription that is not cancelled for this product", ErrorTypeEnum.BadRequest);
            }

            // Get active users count
            int numberOfActiveGlobalUsers = GetNumberOfActiveUsersForTheSubscriber(createStripePaymentSessionCommand);
            if (numberOfActiveGlobalUsers == 0)
            {
                return GetError<CreatePaymentSessionResponse>("This subscriber has no active users", ErrorTypeEnum.BadRequest);
            }

            // Generate a payment link for the subscription
            OneOf<CreatePaymentSessionResponse, ReposityFailedResponse> response = await GeneratePaymentLinkForTheSubscription(createStripePaymentSessionCommand, linkSubscriberToStripeCustomer, price, numberOfActiveGlobalUsers, cancellationToken);
            return response.Match(
                result => GetResult(result, ResultType.Created),
                error => GetError<CreatePaymentSessionResponse>(error)
            );
        }

        private async Task<OneOf<CreatePaymentSessionResponse, ReposityFailedResponse>> GeneratePaymentLinkForTheSubscription(CreateStripePaymentSessionCommand createStripePaymentSessionCommand, LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer, string? price, int numberOfActiveGlobalUsers, CancellationToken cancellationToken)
        {
            CreatePaymentSessionRequest createPaymentSessionRequest = new()
            {
                Price = price,
                Quantity = numberOfActiveGlobalUsers,
                SuccessUrl = createStripePaymentSessionCommand.SuccessUrl,
                CancelUrl = createStripePaymentSessionCommand.CancelUrl,
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!
            };

            return await _sessionService.CreatePaymentLink(createPaymentSessionRequest, cancellationToken);
        }

        private int GetNumberOfActiveUsersForTheSubscriber(CreateStripePaymentSessionCommand createStripePaymentSessionCommand) =>
            _sharedDbContext
                .GlobalUsers
                .Count(x =>
                    x.SubscriberId == createStripePaymentSessionCommand.SubscriberId
                    && !x.Deleted);

        private static IEnumerable<StripeSubscriptionDto> GetNonCancelledSubscriptions(OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse> listStripeSubscriptionResponse) =>
            listStripeSubscriptionResponse
                .AsT0
                .StripeSubscriptionDtos
                .Where(x => x.Status != "canceled");

        private async Task<OneOf<ListStripeSubscriptionResponse, ReposityFailedResponse>> ListSubscriptions(LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer, string? price, CancellationToken cancellationToken)
        {
            ListStripeSubscriptionRequest listStripeSubscriptionRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!,
                Price = price
            };

            return await _stripeApiSubscriptionService.ListStripeSubscriptionAsync(listStripeSubscriptionRequest, cancellationToken);
        }

        private async Task ExpireActivePaymentSessions(OneOf<ListPaymentSessionResponse, ReposityFailedResponse> listPaymentSessionResponse, CancellationToken cancellationToken)
        {
            IEnumerable<PaymentSessionDto> openSessions =
                listPaymentSessionResponse
                .AsT0
                .PaymentSessionDtos
                .Where(x => x.Status == "open")
                .ToList();

            int expireCount = 1;
            foreach (PaymentSessionDto openSessionDto in openSessions)
            {
                _logger.LogInformation($"expire count {expireCount++}");
                await _sessionService.ExpirePaymentLink(new ExpirePaymentSessionRequest
                {
                    Id = openSessionDto.Id
                }, cancellationToken);
            }
        }

        private async Task<OneOf<ListPaymentSessionResponse, ReposityFailedResponse>> ListPaymentSessions(LinkSubscriberToStripeCustomer? linkSubscriberToStripeCustomer, CancellationToken cancellationToken)
        {
            ListPaymentSessionRequest listPaymentSessionRequest = new()
            {
                StripeCustomerId = linkSubscriberToStripeCustomer.StripeCustomerId!
            };

            return await _sessionService.ListPaymentLinks(listPaymentSessionRequest, cancellationToken);
        }

        private LinkSubscriberToStripeCustomer? GetLinkedStripeCustomer(CreateStripePaymentSessionCommand createStripePaymentSessionCommand) =>
            _sharedDbContext.LinkSubscriberToStripeCustomers
                .FirstOrDefault(dbX => dbX.SubscriberId == createStripePaymentSessionCommand.SubscriberId);

        private string? GetPrice(CreateStripePaymentSessionCommand request)
            => request.PaymentSessionFrequency switch
            {
                PaymentSessionFrequency.Yearly => _stripeSettings.SubscriptionYearlyPriceId,
                PaymentSessionFrequency.Monthly => _stripeSettings.SubscriptionMonthlyPriceId,
                _ => null,
            };
    }
}
