using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Company
{
    public int CompanyId { get; set; }

    public int SubscriberId { get; set; }

    public string? Address { get; set; }

    public int AnnualRevenue { get; set; }

    public string? AnnualShipments { get; set; }

    public string? AnnualVolumes { get; set; }

    public string? CampaignName { get; set; }

    public string? City { get; set; }

    public string? Comments { get; set; }

    public string? Commodities { get; set; }

    public string? CompanyCode { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanySegmentCode { get; set; }

    public string? CompanySegmentName { get; set; }

    public string? CompanyTypes { get; set; }

    public string? Competitors { get; set; }

    public string? ControllingSalesRepCode { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public string? CustomerBillingCode { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public decimal? CreditLimit { get; set; }

    public int? DaysNoShipments { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? Destinations { get; set; }

    public string? Division { get; set; }

    public string? DunsNumber { get; set; }

    public string? Fax { get; set; }

    public DateTime? FileUploadDate { get; set; }

    public DateTime? FirstShipmentDate { get; set; }

    public string? FreightServices { get; set; }

    public string? Incoterms { get; set; }

    public string? Industry { get; set; }

    public bool IsCustomer { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public DateTime? LastCreditUpdate { get; set; }

    public DateTime? LastShipmentDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? MaintenanceSalesRepCode { get; set; }

    public DateTime? NextActivityDate { get; set; }

    public int? NumberOfEmployees { get; set; }

    public int OriginatingUserId { get; set; }

    public string? OriginatingUserName { get; set; }

    public string? Origins { get; set; }

    public string? OriginSystem { get; set; }

    public string? OriginSystemSalesRepCodes { get; set; }

    public string? Phone { get; set; }

    public string? Phone2 { get; set; }

    public string? PostalCode { get; set; }

    public int? ParentCompanyId { get; set; }

    public string? ParentCompanyName { get; set; }

    public int? RevenueLastPeriod { get; set; }

    public int? RevenueYtd { get; set; }

    public string? SalesTeam { get; set; }

    public string? ServiceSalesRepCode { get; set; }

    public string? Siccode { get; set; }

    public string? Source { get; set; }

    public string? SourceDataCenter { get; set; }

    public int? SourceDataCenterCompanyId { get; set; }

    public int? SourceSubscriberId { get; set; }

    public string? StateProvince { get; set; }

    public string? Status { get; set; }

    public string? Tags { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public string? Website { get; set; }

    public int ConversionAccountId { get; set; }

    public int ConversionLeadId { get; set; }

    public string? ConversionType { get; set; }

    public bool? Active { get; set; }

    public int? CompanyOwnerUserId { get; set; }

    public bool? AdminOverideActive { get; set; }

    public DateTime? AdminOverideActiveDate { get; set; }

    public int? Claimed { get; set; }

    public DateTime? ClaimedDate { get; set; }

    public int? ClaimedUserId { get; set; }

    public string? ClaimedUserName { get; set; }

    public int CompanyIdGlobal { get; set; }

    public int? PrimaryContactId { get; set; }

    public string? ParentCode { get; set; }

    public int CompanyOwnerUserIdGlobal { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public int DeletedUserIdGlobal { get; set; }
}
