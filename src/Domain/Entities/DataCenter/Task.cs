using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Task
{
    public int TaskId { get; set; }

    public int SubscriberId { get; set; }

    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public bool Completed { get; set; }

    public int CompletionPercent { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public int DealId { get; set; }

    public string? DealName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? Description { get; set; }

    public DateTime DueDate { get; set; }

    public string? ExchangeSyncId { get; set; }

    public DateTime? ExchangeSyncLastModified { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? SourceDataCenter { get; set; }

    public int? SourceDataCenterTaskId { get; set; }

    public int? SourceSubscriberId { get; set; }

    public DateTime StartDate { get; set; }

    public string? Tags { get; set; }

    public string TaskName { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UserId { get; set; }

    public int ConversionActivityId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public int CreatedGlobalUserId { get; set; }

    public int GlobalUserId { get; set; }

    public string? UserName { get; set; }

    public string? CompanyIdGlobals { get; set; }

    public string? CompanyNames { get; set; }

    public string? CompanyIds { get; set; }

    public string? ContactIds { get; set; }

    public string? Contacts { get; set; }

    public string? Campaigns { get; set; }

    public string? DealTypes { get; set; }

    public string? UserLocation { get; set; }

    public bool SavedAsActivity { get; set; }

    public string? Competitors { get; set; }
}
