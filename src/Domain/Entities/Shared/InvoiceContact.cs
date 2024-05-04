using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class InvoiceContact
{
    public int InvoiceContactId { get; set; }

    public int InvoiceId { get; set; }

    public int BillingContactId { get; set; }
}
