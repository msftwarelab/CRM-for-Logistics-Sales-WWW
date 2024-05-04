using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Activity
{
    public int ActivityId { get; set; }

    public Guid Guid { get; set; }

    public int SubscriberId { get; set; }

    public DateTime ActivityDate { get; set; }

    public int AdminActiveOveride { get; set; }

    public DateTime? AdminActiveOverideDate { get; set; }

    public string? ActivityType { get; set; }

    public string? BusyFree { get; set; }

    public int CalendarEventId { get; set; }

    public string? Campaigns { get; set; }

    public string? CampaignIds { get; set; }

    public string? CategoryIds { get; set; }

    public int CategoryId { get; set; }

    public string? CategoryColor { get; set; }

    public string? CategoryName { get; set; }

    public int CompanyId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public string? CompanyName { get; set; }

    public int CompanySubscriberId { get; set; }

    public string? Competitors { get; set; }

    public bool Completed { get; set; }

    public int CompletionPercent { get; set; }

    public string? ContactIds { get; set; }

    public string? ContactNames { get; set; }

    public int ConversionActivityId { get; set; }

    public DateTime? ConversionCreatedDateTime { get; set; }

    public DateTime? ConversionUpdatedDateTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string? CreatedUserName { get; set; }

    public string? CreatedUserLocation { get; set; }

    public string? DealIds { get; set; }

    public string? DealNames { get; set; }

    public string? DealTypes { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserId { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public int Duration { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string? EventSubject { get; set; }

    public string? EventTimeZone { get; set; }

    public string? EventType { get; set; }

    public string? ExchangeAppointmentId { get; set; }

    public string? ExchangeAppointmentItemId { get; set; }

    public string? ExchangeSyncId { get; set; }

    public DateTime? ExchangeSyncLastModified { get; set; }

    public string? GoogleSyncId { get; set; }

    public DateTime? GoogleSyncLastModified { get; set; }

    public bool IsAllDay { get; set; }

    public bool? IsRecurring { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? Location { get; set; }

    public string? NoteContent { get; set; }

    public int NoteId { get; set; }

    public string? OriginSystem { get; set; }

    public int OwnerUserId { get; set; }

    public int OwnerUserIdGlobal { get; set; }

    public string? OwnerUserName { get; set; }

    public string? PublicPrivate { get; set; }

    public string? Priority { get; set; }

    public bool Reminder { get; set; }

    public DateTime? ReminderDate { get; set; }

    public int? ReminderIncrement { get; set; }

    public string? ReminderIncrementType { get; set; }

    public int? ReminderMinutes { get; set; }

    public string? ReminderType { get; set; }

    public string? ReminderTypes { get; set; }

    public int? ReoccurNumberOfTimes { get; set; }

    public int? ReoccurrenceIncrement { get; set; }

    public string? ReoccurrenceIncrementType { get; set; }

    public int? ReoccurrenceParentActivityId { get; set; }

    public string? SalesPurpose { get; set; }

    public string? SalesStage { get; set; }

    public bool SavedAsActivity { get; set; }

    public string? SourceDataCenter { get; set; }

    public int? SourceDataCenterCalendarEventId { get; set; }

    public int SourceDataCenterNoteId { get; set; }

    public int SourceDataCenterTaskId { get; set; }

    public int? SourceSubscriberId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? StartDateTime { get; set; }

    public string? Subject { get; set; }

    public string? SyncType { get; set; }

    public string? Tags { get; set; }

    public int TaskId { get; set; }

    public string? TaskName { get; set; }

    public int UpdateUserId { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string? UpdateUserName { get; set; }

    public int UserId { get; set; }

    public int UserIdGlobal { get; set; }

    public string? UserLocation { get; set; }

    public string? UserName { get; set; }

    public string? UserTimeZone { get; set; }

    public string? UtcOffset { get; set; }

    public string? ActivityMembers { get; set; }

    public string? ActivityMembersBak { get; set; }
}
