using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class CurrencyExchangeRate
{
    public int CurrencyExchangeRateId { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? ExchangeDate { get; set; }

    public double? ExchangeRate { get; set; }
}
