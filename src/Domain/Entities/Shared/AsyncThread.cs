using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class AsyncThread
{
    public int AsyncThreadId { get; set; }

    public int SubscriberId { get; set; }

    public int UserIdGlobal { get; set; }

    public bool Completed { get; set; }

    public DateTime DateTimeStart { get; set; }

    public int? Duration { get; set; }

    public bool Error { get; set; }

    public string? ErrorDetails { get; set; }

    public int ItemsTotal { get; set; }

    public int ItemsProcessed { get; set; }

    public int ItemsSuccess { get; set; }

    public int ItemsError { get; set; }

    public string? JobType { get; set; }

    public string? JobSubType { get; set; }

    public string? ResponseJson { get; set; }

    public string? Status { get; set; }

    public int? WorkflowAccountId { get; set; }
}
