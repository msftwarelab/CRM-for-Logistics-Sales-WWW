using Application.Common;
using Application.Common.Responses;
using Application.Repositories.Stripe.Entities.PaymentSession.Create;
using Application.Repositories.Stripe.Entities.Subscription.Update;
using Application.Stripe.PaymentSession.Commands.Create;
using Application.Stripe.Subscription.Commands.Update;
using FirstFreightAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace FirstFreightAPI.Controllers.Stripe
{
    [Route("Stripe/Subscriptions/")]
    [ApiController]
    public class StripeSubscriptionsController : ApiControllerBase
    {
        /// <summary>
        /// Creates a Stripe Payment Session on-demand.
        /// </summary>
        /// <param name="createStripePaymentSessionCommand"></param>
        /// <param name="ct"></param>
        /// <remarks>
        /// Preconditions:
        /// - All existing check sessions for the Stripe Customer will be expired.
        /// - Exactly 1 subscription of the appropriate type must exist for the Stripe Customer.
        /// - The quantity of the subscription will be determined by the number of active GlobalUsers that the subscriber is associated with.
        /// 
        /// Sample request:
        ///
        ///     {
        ///       "subscriberId": 100,
        ///       "successUrl": "http://google.com",
        ///       "cancelUrl": "http://google.com",
        ///       "paymentSessionFrequency": "Monthly"
        ///     }
        /// </remarks>
        /// <returns></returns>
        /// <response code="200">Returns the payment link for the checkout session that will create a subscription on reocurring billing cycle.</response>
        /// <response code="400">If the request parameters are invalid</response>
        /// <response code="500">If an internal error occurred</response>
        [ProducesResponseType(typeof(CreatePaymentSessionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Add")]
        public async Task<IActionResult> CreateStripePaymentSession(
            [FromBody] CreateStripePaymentSessionCommand createStripePaymentSessionCommand,
            CancellationToken ct)
        {
            ApplicationResponse<CreatePaymentSessionResponse> response =
                await Mediator.Send(createStripePaymentSessionCommand, ct);

            return GetResponse(response);
        }

        /// <summary>
        /// Updates a Stripe subscription if the current quantity differs from the number of active GlobalUsers that the subscriber is associated with.
        /// </summary>
        /// <param name="updateStripeSubscriptionCommand"></param>
        /// <param name="ct"></param>
        /// <remarks>
        /// Preconditions:
        /// - Exactly 1 subscription of the appropriate type must exist for the Stripe Customer.
        /// - The quantity of the subscription will be determined by the number of active GlobalUsers that the subscriber is associated with.
        /// 
        /// The Stripe user will be billed immediately upon updating the subscription quantity.
        /// 
        /// Sample request:
        ///
        ///     {
        ///       "subscriberId": 100
        ///     }
        /// </remarks>
        /// <returns></returns>
        /// <response code="200">Returns the payment link for the checkout session that will create a subscription on reocurring billing cycle.</response>
        /// <response code="400">If the request parameters are invalid</response>
        /// <response code="500">If an internal error occurred</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status304NotModified)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateStripeSubscription(
            [FromBody] UpdateStripeSubscriptionCommand updateStripeSubscriptionCommand,
            CancellationToken ct)
        {
            ApplicationResponse<UpdateStripeSubscriptionResponse> response =
                await Mediator.Send(updateStripeSubscriptionCommand, ct);

            return GetResponse(response);
        }
    }
}
