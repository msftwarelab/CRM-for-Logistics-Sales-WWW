using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Region
{
    public int RegionId { get; set; }

    public int SubscriberId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public int? RegionManagerUserIdGlobal { get; set; }

    public string RegionName { get; set; } = null!;

    public string UpdateUserName { get; set; } = null!;

    public int UpdateUserIdGlobal { get; set; }
}
