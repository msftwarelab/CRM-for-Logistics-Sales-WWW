using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class LinkContactToDeal
{
    public int Id { get; set; }

    public int SubscriberId { get; set; }

    public int ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public int CreatedUserId { get; set; }

    public int DealId { get; set; }

    public string DealName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string LinkType { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;
}
