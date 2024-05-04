using Application.Common;
using Application.Common.Responses;
using Application.Repositories.Stripe.Entities.Invoice.Add;
using Application.Repositories.Stripe.Entities.Invoice.Common;
using Application.Repositories.Stripe.Entities.Invoice.Pay;
using Application.Repositories.Stripe.Entities.Invoice.Update;
using Application.Stripe.Invoice.Commands.Create;
using Application.Stripe.Invoice.Commands.Pay;
using Application.Stripe.Invoice.Commands.Update;
using Application.Stripe.Invoice.Queries.Get;
using FirstFreightAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace FirstFreightAPI.Controllers.Stripe
{
    [Route("Stripe/Invoices/")]
    [ApiController]
    public class StripeInvoicesController : ApiControllerBase
    {
        /// <summary>
        /// Gets an Invoice for Subscriber.
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="invoiceId">The First Freight Invoice Id</param>
        /// <param name="ct"></param>
        /// <remarks>
        /// The URL will only be valid for 30 days after the due date, if it expires, request a new one here.
        /// </remarks>
        /// <returns></returns>
        /// <response code="200">Returns the Stripe Invoice</response>
        /// <response code="400">If the request parameters are invalid</response>
        /// <response code="500">If an internal error occurred</response>
        [ProducesResponseType(typeof(StripeInvoiceDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpGet("{subscriberId}/{invoiceId}")]
        public async Task<IActionResult> AddStripeInvoice(
        [FromRoute] int subscriberId,
        [FromRoute] string invoiceId,
            CancellationToken ct)
        {
            ApplicationResponse<StripeInvoiceDto> response =
                await Mediator.Send(new GetStripeInvoiceCommand
                {
                    SubscriberId = subscriberId,
                    FirstFreightInvoiceId = invoiceId
                }, ct);

            return GetResponse(response);
        }

        /// <summary>
        /// Creates an Invoice for Subscriber that already has an associated Stripe Customer.
        /// The Invoice will be finialized and ready immediately.
        /// </summary>
        /// <param name="addStripeInvoiceCommand"></param>
        /// <param name="ct"></param>
        /// <remarks>
        /// Precondition: If a Subscriber already has a Invoice with the same ID, a 400 bad request will be returned.
        /// 
        /// The URL will only be valid for 30 days after the due date, request a GET: /Stripe/Invoices/{InvoiceId} to get a new URL.
        /// 
        /// Sample request:
        ///
        ///     {
        ///       "firstFreightInvoiceId": "invoiceId1",
        ///       "subscriberId": 100,
        ///       "costInCents": 100000,
        ///       "dueDateInUtc": "2023-06-13T04:08:11.491Z"
        ///     }
        /// </remarks>
        /// <returns></returns>
        /// <response code="201">Returns the newly created Stripe Invoice Id and Url</response>
        /// <response code="400">If the request parameters are invalid</response>
        /// <response code="500">If an internal error occurred</response>
        [ProducesResponseType(typeof(AddStripeInvoiceResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Add")]
        public async Task<IActionResult> AddStripeInvoice(
        [FromBody] AddStripeInvoiceCommand addStripeInvoiceCommand,
            CancellationToken ct)
        {
            ApplicationResponse<AddStripeInvoiceResponse> response =
                await Mediator.Send(addStripeInvoiceCommand, ct);

            return GetResponse(response);
        }

        /// <summary>
        /// Updates an Invoice. The Invoice will be finialized and ready immediately.
        /// </summary>
        /// <param name="updateStripeInvoiceCommand"></param>
        /// <param name="ct"></param>
        /// <remarks>
        /// Precondition: Invoices can only be updated a maximum of 4 times.
        /// 
        /// The original URL will redirect to the new URL automatically as long as it is still valid.
        /// The URL will only be valid for 30 days after the due date, request a GET: /Stripe/Invoices/{InvoiceId} to get a new URL.
        /// 
        /// Sample request:
        ///
        ///     {
        ///       "firstFreightInvoiceId": "invoiceId1",
        ///       "subscriberId": 100,
        ///       "costInCents": 100000,
        ///       "dueDateInUtc": "2023-06-13T04:08:11.491Z"
        ///     }
        /// </remarks>
        /// <returns></returns>
        /// <response code="201">Returns the newly created Stripe Invoice Id and Url</response>
        /// <response code="400">If the request parameters are invalid</response>
        /// <response code="500">If an internal error occurred</response>
        [ProducesResponseType(typeof(AddStripeInvoiceResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateStripeInvoice(
            [FromBody] UpdateStripeInvoiceCommand updateStripeInvoiceCommand,
            CancellationToken ct)
        {
            ApplicationResponse<UpdateStripeInvoiceResponse> response =
                await Mediator.Send(updateStripeInvoiceCommand, ct);

            return GetResponse(response);
        }

        /// <summary>
        /// Marks the Invoice as paid externally.
        /// </summary>
        /// <param name="payStripeInvoiceCommand"></param>
        /// <param name="ct"></param>
        /// <remarks>
        /// Precondition: The invoice must be in the status of "open" (finalized).
        /// 
        /// Sample request:
        ///
        ///     {
        ///       "firstFreightInvoiceId": "invoiceId1",
        ///       "subscriberId": 100
        ///     }
        /// </remarks>
        /// <returns></returns>
        /// <response code="204"></response>
        /// <response code="400">If the request parameters are invalid</response>
        /// <response code="500">If an internal error occurred</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [HttpPost("MarkAsPaid")]
        public async Task<IActionResult> PayStripeInvoice(
            [FromBody] PayStripeInvoiceCommand payStripeInvoiceCommand,
            CancellationToken ct)
        {
            ApplicationResponse<PayStripeInvoiceResponse> response =
                await Mediator.Send(payStripeInvoiceCommand, ct);

            return GetResponse(response);
        }
    }
}
