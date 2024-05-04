using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class InvoiceEmail
{
    public int InvoiceEmailId { get; set; }

    public int InvoiceId { get; set; }

    public string? Subject { get; set; }

    public string? EmailBody { get; set; }

    public DateTime SentDate { get; set; }

    public int SentBy { get; set; }
}
