using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Subscriber
{
    public int SubscriberId { get; set; }

    public bool Active { get; set; }

    public string? Address { get; set; }

    public bool? Billable { get; set; }

    public string? BillingCurrencyCode { get; set; }

    public string? BillingCurrencySymbol { get; set; }

    public decimal? BillingUserRate { get; set; }

    public decimal? BillingUserReadOnlyRate { get; set; }

    public string? City { get; set; }

    public string CompanyName { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public string CrmAdminEmail { get; set; } = null!;

    public string? DataCenter { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string DefaultDateFormat { get; set; } = null!;

    public int DefaultLeadResponseDays { get; set; }

    public string DefaultReportCurrencyCode { get; set; } = null!;

    public string DefaultReportDateFormat { get; set; } = null!;

    public string DefaultShippingFrequency { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? EmailDisclaimer { get; set; }

    public string? EmailFrom { get; set; }

    public string? ExchangeDomain { get; set; }

    public string? ExchangeServerTimeZone { get; set; }

    public string? ExchangeUrl { get; set; }

    public string? Fax { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LogonUrl { get; set; }

    public string? Phone { get; set; }

    public string? PostalCode { get; set; }

    public string? SsoApiKey { get; set; }

    public string? StateProvince { get; set; }

    public string? SubDomain { get; set; }

    public string? SubscriberApiKey { get; set; }

    public string? SubscriberIpAddress { get; set; }

    public string? SyncType { get; set; }

    public string? SyncServiceDomain { get; set; }

    public string? SyncServicePassword { get; set; }

    public string? SyncServiceUrl { get; set; }

    public string? SyncServiceUserName { get; set; }

    public int? UpdateUserId { get; set; }

    public string? UpdateUserName { get; set; }

    public int? UserLimit { get; set; }

    public virtual ICollection<DealInvite> DealInvites { get; set; } = new List<DealInvite>();

    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    public virtual ICollection<SalesManager> SalesManagers { get; set; } = new List<SalesManager>();
}
