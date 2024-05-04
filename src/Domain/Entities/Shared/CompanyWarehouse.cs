using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class CompanyWarehouse
{
    public int WarehouseId { get; set; }

    public int SubscriberId { get; set; }

    public int UserIdGlobal { get; set; }

    public int CompanyIdGlobal { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserIdGlobal { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public int LastUpdatedUserIdGlobal { get; set; }

    public string? WarehouseIncumbentOrTarget { get; set; }

    public string? WarehouseLocation { get; set; }

    public double WarehouseSqMeters { get; set; }

    public string? WarehouseCategory { get; set; }
}
