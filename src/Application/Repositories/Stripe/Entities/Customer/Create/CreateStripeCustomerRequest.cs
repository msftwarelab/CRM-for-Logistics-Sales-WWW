using System.ComponentModel.DataAnnotations;

namespace Application.Repositories.Stripe.Entities.Customer.Create
{
    public class CreateStripeCustomerRequest
    {
        public string CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string CustomerDescription { get; set; }
        public string CustomerPhone { get; set; }

        [Required]
        public int SubscriberId { get; set; }
    }
}
