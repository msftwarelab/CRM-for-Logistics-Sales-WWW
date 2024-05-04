using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class CompanyContactsImportRequest
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public int SubscriberId { get; set; }

    public int UserIdGlobal { get; set; }

    public int CompanyOwnerId { get; set; }

    public bool Completed { get; set; }

    public int TotalCount { get; set; }

    public int CompletedCount { get; set; }

    public int DuplicateCount { get; set; }

    public int ErrorCount { get; set; }

    public string? Data { get; set; }

    public int ProcessDurationMs { get; set; }

    public DateTime RequestDate { get; set; }
}
