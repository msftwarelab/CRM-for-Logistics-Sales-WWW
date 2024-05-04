using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class CalendarInvite
{
    public int CalendarEventInviteId { get; set; }

    public int SubscriberId { get; set; }

    public int CalendarEventId { get; set; }

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

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public int? ContactId { get; set; }

    public string? ContactName { get; set; }

    public string? AttendeeType { get; set; }
}
