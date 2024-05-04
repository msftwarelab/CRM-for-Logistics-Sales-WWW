using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class ExchangeServerTimezone
{
    public int Id { get; set; }

    public string ExchangeServerTimeZone1 { get; set; } = null!;

    public string? TimeZoneDescription { get; set; }
}
