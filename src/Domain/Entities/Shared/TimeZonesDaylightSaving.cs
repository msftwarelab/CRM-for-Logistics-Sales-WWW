using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class TimeZonesDaylightSaving
{
    public int TimeZonesDaylightSavingsId { get; set; }

    public DateTime DstStartDate { get; set; }

    public DateTime DstEndDate { get; set; }

    public string? TimeZoneName { get; set; }

    public string TimeZoneFullName { get; set; } = null!;

    public int TimeZoneYear { get; set; }

    public string UtcOffset { get; set; } = null!;
}
