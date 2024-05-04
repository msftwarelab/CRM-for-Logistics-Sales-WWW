using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Stripe.Entities.Invoice.Common
{
    public class StripePrice
    {
        public long UnitAmount { get; set; }
        public string Currency { get; set; }
    }
}
