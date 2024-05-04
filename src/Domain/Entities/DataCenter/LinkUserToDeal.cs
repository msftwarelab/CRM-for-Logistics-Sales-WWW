using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class LinkUserToDeal
{
    public int Id { get; set; }

    public int SubscriberId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string? CreatedUserName { get; set; }

    public int DealId { get; set; }

    public string DealName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string LinkType { get; set; } = null!;

    public string? SalesTeamRole { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public string? UserDataCenter { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int UserSubscriberId { get; set; }

    public bool InviteAccepted { get; set; }

    public string? InviteStatus { get; set; }

    public string? InviteGuid { get; set; }
}
