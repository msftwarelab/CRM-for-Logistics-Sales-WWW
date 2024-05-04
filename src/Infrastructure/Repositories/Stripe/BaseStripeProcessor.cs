using Application.Repositories.Common;
using Domain.Enums;
using Microsoft.Extensions.Logging;
using OneOf;
using Stripe;

namespace Infrastructure.ExternalApi.Stripe
{
    public abstract class BaseStripeProcessor
    {
        private readonly ILogger<BaseStripeProcessor> _logger;

        protected BaseStripeProcessor(ILogger<BaseStripeProcessor> logger)
        {
            _logger = logger;
        }

        private protected async Task<OneOf<TResponse, TResponse2, ReposityFailedResponse>> TryProcessStripeCommand<TResponse, TResponse2>(Func<Task<OneOf<TResponse, TResponse2, ReposityFailedResponse>>> action)
        {
            try
            {
                return await action();
            }
            catch (StripeException ex)
            {
                return HandleStripeException<TResponse>(ex);
            }
            catch (Exception ex)
            {
                return HandleUnhandledException<TResponse>(ex);
            }
        }

        private protected async Task<OneOf<TResponse, ReposityFailedResponse>> TryProcessStripeCommand<TResponse>(Func<Task<OneOf<TResponse, ReposityFailedResponse>>> action)
        {
            try
            {
                return await action();
            }
            catch (StripeException ex)
            {
                return HandleStripeException<TResponse>(ex);
            }
            catch (Exception ex)
            {
                return HandleUnhandledException<TResponse>(ex);
            }
        }

        private ReposityFailedResponse HandleUnhandledException<TResponse>(Exception ex)
        {
            _logger.LogError(ex, "Unexpected error.");
            return new ReposityFailedResponse(ex);
        }

        private ReposityFailedResponse HandleStripeException<TResponse>(StripeException ex)
        {
            switch (ex.StripeError.Type)
            {
                case "card_error":
                case "invalid_request_error":
                    return new ReposityFailedResponse(ex, ex.StripeError.Message, ErrorTypeEnum.BadRequest);
                case "api_connection_error":
                case "api_error":
                case "authentication_error":
                case "rate_limit_error":
                case "validation_error":
                default:
                    _logger.LogError(ex, "Stripe error.");
                    break;
            }

            return new ReposityFailedResponse(ex);
        }
    }
}