using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GlobalLocation
{
    public int GlobalLocationId { get; set; }

    public bool Airport { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public string? IataCode { get; set; }

    public bool InlandPort { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationName { get; set; }

    public bool MultiModal { get; set; }

    public bool RoadTerminal { get; set; }

    public bool RailTerminal { get; set; }

    public bool SeaPort { get; set; }

    public string? UnlocoCode { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;
}
