using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Note
{
    public int NoteId { get; set; }

    public int SubscriberId { get; set; }

    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int ContactId { get; set; }

    public string? ContactName { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public int DealId { get; set; }

    public string? DealName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? NoteContent { get; set; }

    public string? SourceDataCenter { get; set; }

    public int? SourceDataCenterNoteId { get; set; }

    public int? SourceSubscriberId { get; set; }

    public string? Tags { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int ConversionActivityId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public int CreatedGlobalUserId { get; set; }

    public string? Campaigns { get; set; }

    public string? DealTypes { get; set; }

    public string? CreatedUserLocation { get; set; }

    public bool SavedAsActivity { get; set; }

    public string? Competitors { get; set; }
}
