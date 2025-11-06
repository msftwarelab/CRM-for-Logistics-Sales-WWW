using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace FirstFreightAPI.Controllers.REMOVE
{
    /*
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        public readonly string WEBHOOKID = "WEBHOOKID";
        // POST: api/StripeSubscriptions/AddStripeSubscription
        // To create new Stripe Subscription with AddStripeSubscription Model
        [HttpPost]
        public async Task<IActionResult> WebHook()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            try
            {
                var stripeEvent = EventUtility.ConstructEvent(json,
                    Request.Headers["Stripe-Signature"], WEBHOOKID);

                // Handle the event
                if (stripeEvent.Type == Events.CustomerCreated)
                {
                    Console.WriteLine("Create Customer");
                }
                else if (stripeEvent.Type == Events.CustomerUpdated)
                {
                    Console.WriteLine("Update Customer");
                }
                else if (stripeEvent.Type == Events.CustomerDeleted)
                {
                    Console.WriteLine("Delete Customer");
                }
                else if (stripeEvent.Type == Events.CustomerSubscriptionCreated)
                {
                    Console.WriteLine("Create customer subscription");
                }
                // ... handle other event types
                else
                {
                    Console.WriteLine("Unhandled event type: {0}", stripeEvent.Type);
                }

                return Ok();
            }
            catch (StripeException e)
            {
                return BadRequest();
            }
        }
    }
    */
}
