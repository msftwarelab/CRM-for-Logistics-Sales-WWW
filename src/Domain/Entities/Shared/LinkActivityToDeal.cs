using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkActivityToDeal
{
    public int LinkActivityToDealId { get; set; }

    public int SubscriberId { get; set; }

    public int ActivityId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string? CreatedUserName { get; set; }

    public int DealId { get; set; }

    public int DealIdGlobal { get; set; }

    public string DealName { get; set; } = null!;

    public int DealSubscriberId { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public int UpdateUserIdGlobal { get; set; }
}
