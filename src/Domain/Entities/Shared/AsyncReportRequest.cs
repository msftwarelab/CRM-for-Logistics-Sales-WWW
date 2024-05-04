using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class AsyncReportRequest
{
    public int Id { get; set; }

    public DateTime RequestedDate { get; set; }

    public int RequestedBy { get; set; }

    public int SubscriberId { get; set; }

    public string? ReportName { get; set; }

    public string? ExcelFileUrl { get; set; }

    public string? JsonFileUrl { get; set; }

    public bool JsonDeleted { get; set; }

    public string? JsonfileContainerReference { get; set; }

    public string? JsonfileBlobReference { get; set; }

    public bool Completed { get; set; }

    public string? RefId { get; set; }

    public string? Error { get; set; }

    public int ElapsedTime { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int TotalCount { get; set; }

    public int CompletedCount { get; set; }
}
