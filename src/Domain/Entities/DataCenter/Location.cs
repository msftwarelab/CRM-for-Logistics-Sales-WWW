using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Location
{
    public int LocationId { get; set; }

    public int SubscriberId { get; set; }

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? Comments { get; set; }

    public string? CountryCode { get; set; }

    public string CountryName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public string? CurrencyCode { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? DistrictCode { get; set; }

    public int? DiscrictId { get; set; }

    public string? DistrictName { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Hours { get; set; }

    public DateTime LastUpdate { get; set; }

    public int? Latitude { get; set; }

    public string? LocationCode { get; set; }

    public int? LocationManagerUserId { get; set; }

    public string LocationName { get; set; } = null!;

    public string LocationType { get; set; } = null!;

    public int? Longitude { get; set; }

    public string? Phone { get; set; }

    public string? Phone2 { get; set; }

    public string? Phone3 { get; set; }

    public string? PostalCode { get; set; }

    public string? RegionCode { get; set; }

    public int? RegionId { get; set; }

    public string? RegionName { get; set; }

    public string StateProvince { get; set; } = null!;

    public string? TimeZone { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public int ConversionLocationId { get; set; }
}
