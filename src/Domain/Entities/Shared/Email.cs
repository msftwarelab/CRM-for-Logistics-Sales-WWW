using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Email
{
    public int EmailId { get; set; }

    public int? SubscriberId { get; set; }

    public string? CcEmailAddresses { get; set; }

    public int Clicks { get; set; }

    public int CompanyId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public int ContactId { get; set; }

    public DateTime? DateSent { get; set; }

    public int DealId { get; set; }

    public int DealIdGlobal { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public int? DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public string? EmailBodyHtml { get; set; }

    public string? EmailBodyText { get; set; }

    public string? EmailHeaders { get; set; }

    public string? Error { get; set; }

    public int? EventId { get; set; }

    public string? FromEmailAddress { get; set; }

    public string? FromName { get; set; }

    public bool IsError { get; set; }

    public string? MailboxHash { get; set; }

    public string? MessageId { get; set; }

    public int Opens { get; set; }

    public string? RecipientEmailAddresses { get; set; }

    public string? ReplyToEmailAddress { get; set; }

    public string? Subject { get; set; }

    public string? Tags { get; set; }

    public string? ToEmail { get; set; }

    public int? SentByUserId { get; set; }

    public int SentToUserId { get; set; }

    public int SentToContactId { get; set; }

    public DateTime? UtcSentDateTime { get; set; }

    public int GlobalContactId { get; set; }
}
