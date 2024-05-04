using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class InvoiceStatusHistory
{
    public int InvoiceStatusHistoryId { get; set; }

    public int InvoiceId { get; set; }

    public int UserId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreatedDate { get; set; }
}
