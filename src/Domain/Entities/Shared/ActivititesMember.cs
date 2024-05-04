using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class ActivititesMember
{
    public int ActivityMemberId { get; set; }

    public int SubscriberId { get; set; }

    public int ActivitiesId { get; set; }

    public string? AttendeeType { get; set; }

    public int? ContactId { get; set; }

    public int GlobalContactId { get; set; }

    public string? ContactName { get; set; }

    public int? ContactSubscriberId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? Email { get; set; }

    public bool InviteAccepted { get; set; }

    public string InviteType { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public int? ReminderJobId { get; set; }

    public bool ReminderSent { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int? UserId { get; set; }

    public int? UserIdGlobal { get; set; }

    public string? UserName { get; set; }
}
