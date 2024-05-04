namespace Application.Repositories.Stripe.Entities.Customer.Common
{
    public class CustomerAddress
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string PostalCode { get; set; }
    }
}
