using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class CalendarEvent
{
    public int CalendarEventId { get; set; }

    public int SubscriberId { get; set; }

    public int OwnerUserId { get; set; }

    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

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

    public int Duration { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string EventType { get; set; } = null!;

    public string? ExchangeAppointmentId { get; set; }

    public DateTime? ExchangeSyncLastModified { get; set; }

    public string? GoogleSyncId { get; set; }

    public DateTime? GoogleSyncLastModified { get; set; }

    public bool IsAllDay { get; set; }

    public bool? IsRecurring { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? Location { get; set; }

    public string? OriginSystem { get; set; }

    public string? Priority { get; set; }

    public bool Reminder { get; set; }

    public DateTime? ReminderDate { get; set; }

    public int? ReminderIncrement { get; set; }

    public string? ReminderIncrementType { get; set; }

    public string? ReminderType { get; set; }

    public int? ReoccurNumberOfTimes { get; set; }

    public bool Reoccurrence { get; set; }

    public int? ReoccurrenceIncrement { get; set; }

    public string? ReoccurrenceIncrementType { get; set; }

    public int? ReoccurrenceParentActivityId { get; set; }

    public string? SalesPurpose { get; set; }

    public string? SalesStage { get; set; }

    public string? SourceDataCenter { get; set; }

    public int? SourceDataCenterCalendarEventId { get; set; }

    public int? SourceSubscriberId { get; set; }

    public DateTime StartDateTime { get; set; }

    public string Subject { get; set; } = null!;

    public string? SyncType { get; set; }

    public string? Tags { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public string UserTimeZone { get; set; } = null!;

    public string UtcOffset { get; set; } = null!;

    public int ConversionActivityId { get; set; }

    public bool? AdminActiveOveride { get; set; }

    public DateTime? AdminActiveOverideDate { get; set; }

    public int CompanyIdGlobal { get; set; }

    public string? BusyFree { get; set; }

    public int? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? EventTimeZone { get; set; }

    public string? PublicPrivate { get; set; }

    public int? ReminderMinutes { get; set; }

    public string? CategoryColor { get; set; }

    public string? ExchangeAppointmentItemId { get; set; }

    public int CreatedGlobalUserId { get; set; }

    public string? OwnerUserName { get; set; }

    public string? ContactIds { get; set; }

    public string? Contacts { get; set; }

    public string? Campaigns { get; set; }

    public string? DealTypes { get; set; }

    public string? UserLocation { get; set; }

    public bool SavedAsActivity { get; set; }

    public string? Competitors { get; set; }
}
