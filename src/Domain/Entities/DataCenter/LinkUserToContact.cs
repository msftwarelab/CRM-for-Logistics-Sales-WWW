using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class LinkUserToContact
{
    public int LinkUserToContactId { get; set; }

    public int SubscriberId { get; set; }

    public int ContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public int CreatedUserId { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string LinkType { get; set; } = null!;

    public string? SalesTeamRole { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int? UserIdGlobal { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public bool? InviteAccepted { get; set; }

    public string? InviteStatus { get; set; }

    public string? InviteGuid { get; set; }

    public int UserSubscriberId { get; set; }
}
