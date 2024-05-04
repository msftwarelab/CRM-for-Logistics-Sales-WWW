using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public string? CurrencyCode { get; set; }

    public string? RegionContinent { get; set; }

    public string? Timezone { get; set; }

    public string? CountryDialingCode { get; set; }

    public string? CountryIsoCode { get; set; }

    public string? DataCenter { get; set; }

    public string? DateFormat { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LocalCurrencyCode { get; set; }

    public string? RegionCode { get; set; }

    public string? RegionName { get; set; }

    public int? SortOrder { get; set; }

    public string? UpdatedName { get; set; }
}
