using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class TableStatus
{
    public int TableStatusId { get; set; }

    public int SubscriberId { get; set; }

    public string TableName { get; set; } = null!;

    public DateTime? LastUpdateDate { get; set; }

    public int? LastUpdateUserIdGlobal { get; set; }

    public string? LastUpdateUserName { get; set; }
}
