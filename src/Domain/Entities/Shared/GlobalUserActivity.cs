using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GlobalUserActivity
{
    public int GlobalUserActivityId { get; set; }

    public int? ActivityId { get; set; }

    public string? ActivityType { get; set; }

    public string? Subject { get; set; }

    public int? GlobalCompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int? ContactId { get; set; }

    public int? ContactSubscriberId { get; set; }

    public string? ContactName { get; set; }

    public string? LogData { get; set; }

    public int? GlobalDealId { get; set; }

    public string? DealName { get; set; }

    public int? FilterId { get; set; }

    public string? FilterName { get; set; }

    public string? NoteContent { get; set; }

    public int? QuoteIdGlobal { get; set; }

    public string? QuoteName { get; set; }

    public int SubscriberId { get; set; }

    public string SubscriberName { get; set; } = null!;

    public string? TaskName { get; set; }

    public string UserActivityMessage { get; set; } = null!;

    public DateTime UserActivityTimestamp { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int UserIdGlobal { get; set; }

    public int? UserActivityId { get; set; }

    public int GlobalContactId { get; set; }
}
