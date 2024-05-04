using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Document
{
    public int DocumentId { get; set; }

    public int SubscriberId { get; set; }

    public int ActivityId { get; set; }

    public int CalendarEventId { get; set; }

    public int CompanyId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public int ContactId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int DealId { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public string? Description { get; set; }

    public string DocumentBlobReference { get; set; } = null!;

    public string DocumentBlobContainer { get; set; } = null!;

    public int DocumentFolderId { get; set; }

    public string? DocumentGroup { get; set; }

    public int DocumentType { get; set; }

    public int EmailId { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileType { get; set; }

    public int MessageId { get; set; }

    public int QuoteIdGlobal { get; set; }

    public string? Tags { get; set; }

    public string? Title { get; set; }

    public string UploadedByName { get; set; } = null!;

    public int UploadedUserId { get; set; }

    public int UploadedUserIdGlobal { get; set; }

    public int UserId { get; set; }

    public int UserIdGlobal { get; set; }

    public int LocationId { get; set; }

    public int ConversionDocumentId { get; set; }

    public int GlobalContactId { get; set; }
}
