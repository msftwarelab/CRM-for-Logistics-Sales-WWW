using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class CompanyCompetitor
{
    public int CompetitorId { get; set; }

    public string? Competitor { get; set; }

    public string? Mode { get; set; }

    public string? BusinessDetails { get; set; }

    public int GlobalCompanyId { get; set; }

    public int SubscriberId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int LastUpdatedBy { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public bool Deleted { get; set; }

    public int DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }
}
