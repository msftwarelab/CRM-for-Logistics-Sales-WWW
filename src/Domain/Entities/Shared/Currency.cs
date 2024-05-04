using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Currency
{
    public int CurrencyId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? CurrencyFormat { get; set; }

    public string CurrencyName { get; set; } = null!;

    public string? CurrencySymbol { get; set; }

    public string? SubUnitName { get; set; }

    public int? SubUnitRatio { get; set; }

    public string? UnitName { get; set; }
}
