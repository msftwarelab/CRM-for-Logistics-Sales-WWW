using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class InvoiceSent
{
    public int InvoiceSentId { get; set; }

    public int InvoiceId { get; set; }

    public int BillingContactId { get; set; }

    public int InvoiceEmailId { get; set; }

    public string? EmailAddress { get; set; }

    public string? FullName { get; set; }

    public DateTime SentDate { get; set; }

    public int SentBy { get; set; }

    public string? ToCcBcc { get; set; }
}
