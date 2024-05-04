using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class ReportFilter
{
    public int FilterId { get; set; }

    public int SubscriberId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public string? Data { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? FilterName { get; set; }

    public string? ReportType { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UserId { get; set; }

    public int UserIdGlobal { get; set; }

    public string UserName { get; set; } = null!;
}
