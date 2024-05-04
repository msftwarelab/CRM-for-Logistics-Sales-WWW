using Application.Repositories.Common;
using Application.Repositories.Stripe;
using Application.Repositories.Stripe.Entities.PaymentSession.Common;
using Application.Repositories.Stripe.Entities.PaymentSession.Create;
using Application.Repositories.Stripe.Entities.PaymentSession.Expire;
using Application.Repositories.Stripe.Entities.PaymentSession.List;
using Infrastructure.ExternalApi.Stripe;
using Microsoft.Extensions.Logging;
using OneOf;
using Stripe;
using Stripe.Checkout;

namespace Infrastructure.Repositories.Stripe
{
    public class StripeApiPaymentSessionService : BaseStripeProcessor, IStripeApiPaymentSessionService
    {
        private readonly SessionService _sessionService;

        public StripeApiPaymentSessionService(
            ILogger<StripeApiPaymentSessionService> logger,
            SessionService sessionService)
                : base(logger)
        {
            _sessionService = sessionService;
        }

        public async Task<OneOf<CreatePaymentSessionResponse, ReposityFailedResponse>> CreatePaymentLink(CreatePaymentSessionRequest createPaymentSessionRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand((Func<Task<OneOf<CreatePaymentSessionResponse, ReposityFailedResponse>>>)(async () =>
            {
                SessionCreateOptions options = new()
                {
                    LineItems = new List<SessionLineItemOptions>
                    {
                        new SessionLineItemOptions
                        {
                            Price = createPaymentSessionRequest.Price,
                            Quantity = createPaymentSessionRequest.Quantity,
                        },
                    },
                    Mode = "subscription",
                    SuccessUrl = createPaymentSessionRequest.SuccessUrl,
                    CancelUrl = createPaymentSessionRequest.CancelUrl,
                    Customer = createPaymentSessionRequest.StripeCustomerId
                };

                //SetFreeTrial(options);

                Session session = await _sessionService.CreateAsync(options, cancellationToken: ct);

                return new CreatePaymentSessionResponse(session.Url);
            }));
        }

        public async Task<OneOf<ListPaymentSessionResponse, ReposityFailedResponse>> ListPaymentLinks(ListPaymentSessionRequest listPaymentSessionRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand((Func<Task<OneOf<ListPaymentSessionResponse, ReposityFailedResponse>>>)(async () =>
            {
                SessionListOptions options = new()
                {
                    Customer = listPaymentSessionRequest.StripeCustomerId
                };

                StripeList<Session> sessions = await _sessionService.ListAsync(options, cancellationToken: ct);

                ListPaymentSessionResponse result = new();
                IEnumerable<PaymentSessionDto> sessionDtos = sessions.Select(x => new PaymentSessionDto
                {
                    Id = x.Id,
                    Status = x.Status
                });
                result.PaymentSessionDtos.AddRange(sessionDtos);

                return result;
            }));
        }

        public async Task<OneOf<Task, ReposityFailedResponse>> ExpirePaymentLink(ExpirePaymentSessionRequest expirePaymentSessionRequest, CancellationToken ct)
        {
            return await TryProcessStripeCommand((Func<Task<OneOf<Task, ReposityFailedResponse>>>)(async () =>
            {
                await _sessionService.ExpireAsync(expirePaymentSessionRequest.Id, cancellationToken: ct);

                return Task.CompletedTask;
            }));
        }

        private static void SetFreeTrial(SessionCreateOptions options)
        {
            options.SubscriptionData = new SessionSubscriptionDataOptions
            {
                //TrialEnd = DateTime.Now.AddDays(16),
                TrialSettings = new SessionSubscriptionDataTrialSettingsOptions
                {
                    EndBehavior = new SessionSubscriptionDataTrialSettingsEndBehaviorOptions
                    {
                        MissingPaymentMethod = "cancel",
                    }
                }
            };

            options.PaymentMethodCollection = "if_required";
        }
    }
}
