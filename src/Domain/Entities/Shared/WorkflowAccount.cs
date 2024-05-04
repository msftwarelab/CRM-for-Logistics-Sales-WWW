using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class WorkflowAccount
{
    public int WorkflowAccountId { get; set; }

    public int SubscriberId { get; set; }

    public int UserIdGlobal { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool Deleted { get; set; }

    public int? DeletedUserIdGlobal { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? ErrorDetails { get; set; }

    public string? NylasAccountId { get; set; }

    public string? NylasAccessToken { get; set; }

    public string? NylasProvider { get; set; }

    public string? NylasEmail { get; set; }

    public string? NylasCalendarId { get; set; }

    public DateTime? NylasConnectedDate { get; set; }

    public string? Settings { get; set; }

    public string Status { get; set; } = null!;
}
