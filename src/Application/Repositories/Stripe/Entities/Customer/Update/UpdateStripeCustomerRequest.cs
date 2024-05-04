using Application.Repositories.Stripe.Entities.Customer.Common;

namespace Application.Repositories.Stripe.Entities.Customer.Update
{
    public class UpdateStripeCustomerRequest
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerDescription { get; set; }
        public string CustomerPhone { get; set; }

        public CustomerAddress Address { get; set; }
        public string? Source { get; set; }
    }
}
