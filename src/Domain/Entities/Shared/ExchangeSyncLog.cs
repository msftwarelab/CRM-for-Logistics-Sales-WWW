using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class ExchangeSyncLog
{
    public int ExchangeSyncLogId { get; set; }

    public int ActivityId { get; set; }

    public int ContactId { get; set; }

    public int SubscriberId { get; set; }

    public DateTime SyncDateTime { get; set; }

    public string SyncMessage { get; set; } = null!;

    public string SyncType { get; set; } = null!;

    public int UserId { get; set; }

    public int UserIdGlobal { get; set; }

    public string UserName { get; set; } = null!;
}
