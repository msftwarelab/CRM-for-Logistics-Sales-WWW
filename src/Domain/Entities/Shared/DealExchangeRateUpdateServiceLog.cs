using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class DealExchangeRateUpdateServiceLog
{
    public int Id { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsError { get; set; }

    public string? Guid { get; set; }

    public int DealsUpdated { get; set; }

    public int ErrorDealsCount { get; set; }
}
