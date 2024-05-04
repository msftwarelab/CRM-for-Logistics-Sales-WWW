using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class EventCompany
{
    public int EventCompanyId { get; set; }

    public int SubscriberId { get; set; }

    public int EventId { get; set; }

    public int CompanyId { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public string CreatedByName { get; set; } = null!;

    public string? CompanyName { get; set; }

    public int CompanyIdGlobal { get; set; }
}
