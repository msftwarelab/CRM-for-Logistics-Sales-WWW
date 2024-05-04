namespace Application.Repositories.Stripe.Entities.Customer.Create
{
    public class CreateStripeCustomerResponse
    {
        public CreateStripeCustomerResponse(string stripeCustomerId)
        {
            StripeCustomerId = stripeCustomerId;
        }

        public string StripeCustomerId { get; }
    }
}
