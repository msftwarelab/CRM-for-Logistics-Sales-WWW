using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class CompanyImportRequest
{
    public int Id { get; set; }

    public int RequestUserId { get; set; }

    public int SubscriberId { get; set; }

    public DateTime RequestedDate { get; set; }

    public int CompanyOwnerId { get; set; }

    public bool Completed { get; set; }

    public int CompletedCount { get; set; }

    public int TotalCount { get; set; }

    public int ErrorCount { get; set; }

    public string? Guid { get; set; }

    public string? UploadFileContainerReference { get; set; }

    public string? UploadFileBlobReference { get; set; }
}
