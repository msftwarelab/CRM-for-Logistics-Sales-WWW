using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkCountryRegion
{
    public int LinkCountryRegionId { get; set; }

    public int SubscriberId { get; set; }

    public string CountryCode { get; set; } = null!;

    public string? CountryName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string? CreatedUserName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? RegionCode { get; set; }

    public string? RegionName { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string? UpdateUserName { get; set; }
}
