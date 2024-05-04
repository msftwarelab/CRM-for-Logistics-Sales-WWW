using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class InvoiceActiveUser
{
    public int InvoiceActiveUserId { get; set; }

    public int SubscriberId { get; set; }

    public string? BillingCode { get; set; }

    public string? CountryName { get; set; }

    public int CreatedById { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool Deleted { get; set; }

    public int DeletedById { get; set; }

    public string? FullName { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public int InvoiceId { get; set; }

    public int InvoiceMonth { get; set; }

    public string? InvoiceNumber { get; set; }

    public int InvoiceYear { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LocationName { get; set; }

    public string? RegionName { get; set; }

    public string? SubscriberCompanyName { get; set; }

    public int UpdateUserId { get; set; }

    public string? UpdateUserName { get; set; }

    public DateTime? UserActivationDate { get; set; }

    public double UserBilledAmount { get; set; }

    public DateTime? UserDeactivationDate { get; set; }

    public string? UserEmail { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserRole { get; set; }
}
