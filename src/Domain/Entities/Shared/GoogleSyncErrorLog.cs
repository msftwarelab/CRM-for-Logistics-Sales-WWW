using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GoogleSyncErrorLog
{
    public int GoogleSyncErrorLogId { get; set; }

    public int? ErrorCode { get; set; }

    public DateTime? ErrorDateTime { get; set; }

    public string? ErrorMessage { get; set; }

    public int? GoogleSyncLogId { get; set; }

    public string? ReturnMessage { get; set; }

    public string? RoutineName { get; set; }

    public string? RoutineType { get; set; }

    public int? SubscriberId { get; set; }

    public int? UserId { get; set; }

    public int? UserIdGlobal { get; set; }
}
