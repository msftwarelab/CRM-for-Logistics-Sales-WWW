using Application.Common;
using Application.Common.Responses;
using Application.Repositories.Stripe.Entities.Customer.Create;
using Application.Repositories.Stripe.Entities.Customer.Delete;
using Application.Repositories.Stripe.Entities.Customer.Update;
using Application.Stripe.Customer.Commands.Create;
using Application.Stripe.Customer.Commands.Delete;
using Application.Stripe.Customer.Commands.Update;
using FirstFreightAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace FirstFreightAPI.Controllers.Stripe
{
    [Route("Stripe/Customers/")]
    [ApiController]
    public class StripeCustomersController : ApiControllerBase
    {
        /// <summary>
        /// Creates a Stripe Customer for the Subscriber.
        /// </summary>
        /// <param name="createStripeCustomerRequest"></param>
        /// <param name="ct"></param>
        /// <remarks>
        /// Precondition: If a Subscriber already has a Stripe Customer, a 400 bad request will be returned.
        /// 
        /// Only the `SubscriberId` property is required. If the other properties are not provided, they will be populated with default values from the database.
        /// 
        /// Sample request:
        ///
        ///     {
        ///       "SubscriberId": 100,
        ///       "customerName": "name",
        ///       "customerEmail": "email@email.com",
        ///       "customerDescription": "...", 
        ///       "customerPhone": "0123456789"
        ///     }
        /// </remarks>
        /// <returns></returns>
        /// <response code="201">Returns the newly created Stripe Customer Id</response>
        /// <response code="400">If the request parameters are invalid</response>
        /// <response code="500">If an internal error occurred</response>
        [ProducesResponseType(typeof(CreateStripeCustomerResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Add")]
        public async Task<IActionResult> AddStripeCustomer(
            [FromBody] CreateStripeCustomerRequest createStripeCustomerRequest,
            CancellationToken ct)
        {
            ApplicationResponse<CreateStripeCustomerResponse> response =
                await Mediator.Send(new AddStripeCustomerCommand(createStripeCustomerRequest), ct);

            return GetResponse(response);
        }

        /*
        // POST: api/StripeCustomers/UpdateStrupeCustomer
        // To update the customer data with UpdateStripeCustomer Model
        [HttpPost("UpdateStripeCustomer")]
        public async Task<IActionResult> UpdateStripeCustomer(
            [FromBody] UpdateStripeCustomerRequest customer,
            CancellationToken ct)
        {
            ApplicationResponse<UpdateStripeCustomerResponse> response =
                await Mediator.Send(new UpdateStripeCustomerCommand(customer), ct);

            return GetResponse(response);
        }

        // DELETE: api/StripeCustomers/5
        [HttpPost("DeleteStripeCustomer")]
        public async Task<IActionResult> DeleteStripeCustomer(
            [FromBody] DeleteStripeCustomerRequest customer,
            CancellationToken ct)
        {
            ApplicationResponse<DeleteStripeCustomerResponse> response =
                await Mediator.Send(new DeleteStripeCustomerCommand(customer), ct);

            return GetResponse(response);
        }
        */
    }
}
