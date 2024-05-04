using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace FirstFreightAPI.Controllers.REMOVE
{
    /*
    [Route("api/[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        public readonly string WEBHOOKID = "whsec_9f64504c25cb6591c2c5da79450bddb381443f0ca57d2ca8dc061200eb813b0d";
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
