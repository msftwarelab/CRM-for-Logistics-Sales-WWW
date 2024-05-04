using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class UserActivity
{
    public int UserActivityId { get; set; }

    public int? CalendarEventId { get; set; }

    public string? CalendarEventSubject { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int? ContactId { get; set; }

    public string? ContactName { get; set; }

    public string? LogData { get; set; }

    public int? DealId { get; set; }

    public string? DealName { get; set; }

    public int? FilterId { get; set; }

    public string? FilterName { get; set; }

    public int? NoteId { get; set; }

    public string? NoteContent { get; set; }

    public int? QuoteIdGlobal { get; set; }

    public string? QuoteName { get; set; }

    public int SubscriberId { get; set; }

    public string SubscriberName { get; set; } = null!;

    public int? TaskId { get; set; }

    public string? TaskName { get; set; }

    public string UserActivityMessage { get; set; } = null!;

    public DateTime UserActivityTimestamp { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int UserIdGlobal { get; set; }
}
