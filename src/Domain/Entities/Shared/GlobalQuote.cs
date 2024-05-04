using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GlobalQuote
{
    public int QuoteIdGlobal { get; set; }

    public int SubscriberId { get; set; }

    public int? CompanyId { get; set; }

    public int? CompanyIdGlobal { get; set; }

    public string? CompanyName { get; set; }

    public int? ContactId { get; set; }

    public string? ContactName { get; set; }

    public int CreatedUserId { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? CurrencyCode { get; set; }

    public int? DealId { get; set; }

    public int? DealIdGlobal { get; set; }

    public string? DealName { get; set; }

    public bool Deleted { get; set; }

    public int? DeletedUserId { get; set; }

    public int? DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int OwnerUserId { get; set; }

    public int OwnerUserIdGlobal { get; set; }

    public string OwnerUserName { get; set; } = null!;

    public string QuoteName { get; set; } = null!;

    public decimal? QuoteAmount { get; set; }

    public string? QuoteCode { get; set; }

    public string? QuoteConditions { get; set; }

    public string? QuoteDetails { get; set; }

    public string? QuoteMode { get; set; }

    public string? QuoteNotes { get; set; }

    public string? QuoteStatus { get; set; }

    public DateTime QuoteValidFrom { get; set; }

    public DateTime QuoteValidTo { get; set; }

    public int UpdateUserId { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public int ContactIdGlobal { get; set; }
}
