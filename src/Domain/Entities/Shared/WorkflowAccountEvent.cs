using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class WorkflowAccountEvent
{
    public int WorkflowAccountEventId { get; set; }

    public int SubscriberId { get; set; }

    public int UserIdGlobal { get; set; }

    public int ActivityId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public bool Deleted { get; set; }

    public int? DeletedUserIdGlobal { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? LastWebhookStatus { get; set; }

    public DateTime? LastWebhookDate { get; set; }

    public string? NylasEventId { get; set; }

    public string? JobStatus { get; set; }

    public string? JobStatusType { get; set; }

    public string? JobStatusId { get; set; }

    public DateTime? JobStatusStartDate { get; set; }

    public int WorkflowAccountId { get; set; }
}
