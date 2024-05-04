using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class EmailTemplate
{
    public int EmailTemplateId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedUserId { get; set; }

    public string? CreatedUserName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public int? DeletedUserName { get; set; }

    public string? EmailSignature { get; set; }

    public string EmailType { get; set; } = null!;

    public string? FromEmail { get; set; }

    public string? FromName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdate { get; set; }

    public DateTime? SendAtTime { get; set; }

    public string? SendOnDay { get; set; }

    public int? SubscriberId { get; set; }

    public string? Tags { get; set; }

    public string? TemplateBody { get; set; }

    public string? TemplateSubject { get; set; }

    public string? UpdateUserName { get; set; }

    public int? UpdateUserId { get; set; }

    public string? WeeklyEmailIncludes { get; set; }

    public string? UserRole { get; set; }
}
