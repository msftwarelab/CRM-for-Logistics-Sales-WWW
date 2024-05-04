using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class WonReason
{
    public int WonReasonId { get; set; }

    public int SubscriberId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string WonReasonName { get; set; } = null!;

    public int SortOrder { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;
}
