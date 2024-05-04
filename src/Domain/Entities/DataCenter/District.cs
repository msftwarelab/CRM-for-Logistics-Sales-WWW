using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class District
{
    public int DistrictId { get; set; }

    public int SubscriberId { get; set; }

    public string? Comments { get; set; }

    public string CountryCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string DistrictCode { get; set; } = null!;

    public string? DistrictManagerName { get; set; }

    public int DistrictManagerUserId { get; set; }

    public string DistrictName { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public virtual Subscriber Subscriber { get; set; } = null!;
}
