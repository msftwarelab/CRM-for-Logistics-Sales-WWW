using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class ExchangeSyncErrorLog
{
    public int ExchangeSyncErrorLogId { get; set; }

    public int? SubscriberId { get; set; }

    public string? ErrorCode { get; set; }

    public DateTime? ErrorDateTime { get; set; }

    public string? ErrorMessage { get; set; }

    public string? ReturnMessage { get; set; }

    public string? RoutineName { get; set; }

    public string? RoutineType { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }
}
