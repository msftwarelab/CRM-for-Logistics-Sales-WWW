using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class TimeZone
{
    public int TimeZoneId { get; set; }

    public string CityNames { get; set; } = null!;

    public string? CountryCode { get; set; }

    public string Region { get; set; } = null!;

    public int SortOrder { get; set; }

    public string TimeZoneName { get; set; } = null!;

    public string? TimeZoneIana { get; set; }

    public string? UtcOffset { get; set; }

    public string? EnumTimeZoneId { get; set; }
}
