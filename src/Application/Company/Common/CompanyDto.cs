using Application.Common.Mappings;
using FirstFreightAPI.Entities.Shared;

namespace Application.Company.Common
{
    public class CompanyDto : IMapFrom<GlobalCompany>
    {
        public int GlobalCompanyId { get; set; }

        public int SubscriberId { get; set; }

        public bool? Active { get; set; }

        public string? Address { get; set; }

        public bool AdminOverideActive { get; set; }

        public DateTime? AdminOverideActiveDate { get; set; }

        public string? Campaigns { get; set; }

        public string? City { get; set; }

        public bool Claimed { get; set; }

        public DateTime? ClaimedDate { get; set; }

        public int ClaimedUserId { get; set; }

        public int ClaimedUserIdGlobal { get; set; }

        public string? ClaimedUserName { get; set; }

        public string? CompanyCode { get; set; }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; } = null!;

        public int CompanyOwnerUserId { get; set; }

        public int CompanyOwnerUserIdGlobal { get; set; }

        public string? CompanySegmentName { get; set; }

        public string? Comments { get; set; }

        public string? CompanyTypes { get; set; }

        public string CountryName { get; set; } = null!;

        public string? CountryCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedUserId { get; set; }

        public int CreatedUserIdGlobal { get; set; }

        public string CreatedUserName { get; set; } = null!;

        public int CreditLimit { get; set; }

        public string DataCenter { get; set; } = null!;

        public bool Deleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? DeletedUserId { get; set; }

        public string? DeletedUserName { get; set; }

        public string? Division { get; set; }

        public string EmailAddress { get; set; } = null!;

        public string? Fax { get; set; }

        public DateTime? FirstShipmentDate { get; set; }

        public int GlobalCompanyOwnerGlobalUserId { get; set; }

        public string? GlobalCompanyOwnerName { get; set; }

        public string? Incoterms { get; set; }

        public string? Industry { get; set; }

        public string? Industries { get; set; }

        public string IpAddress { get; set; } = null!;

        public bool IsCustomer { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public DateTime? LastCreditUpdate { get; set; }

        public DateTime? LastShipmentDate { get; set; }

        public DateTime LastUpdate { get; set; }

        public string? LinkedUserEmails { get; set; }

        public string? LinkedUserNames { get; set; }

        public DateTime? NextActivityDate { get; set; }

        public int NumberOfEmployees { get; set; }

        public string? Phone { get; set; }

        public string? Phone2 { get; set; }

        public string? PostalCode { get; set; }

        public int PrimaryContactId { get; set; }

        public int PrimaryGlobalContactId { get; set; }

        public string? SalesTeam { get; set; }

        public string? Source { get; set; }

        public string? SourceDataCenter { get; set; }

        public int SourceDataCenterCompanyId { get; set; }

        public int SourceSubscriberId { get; set; }

        public string? StateProvince { get; set; }

        public string? Tags { get; set; }

        public int UpdateUserId { get; set; }

        public string UpdateUserName { get; set; } = null!;

        public string? Website { get; set; }

        public int ConversionAccountId { get; set; }

        public int ConversionLeadId { get; set; }

        public string? ConversionType { get; set; }

        public DateTime? DataCenterConversionAddedDate { get; set; }

        public DateTime? DataCenterConversionUpdatedDate { get; set; }

        public string? GlobalCompanyOwnerGlobalUserName { get; set; }

        public string? Competitors { get; set; }

        public string? ParentCode { get; set; }

        public int ConversionGlobalCompanyId { get; set; }

        public string? ConversionGlobalCompanyDataCenter { get; set; }

        public string? StrategicSalesPlan { get; set; }

        public double CurrentYearAirTonnageTotal { get; set; }

        public double CurrentYearAirTonnageShare { get; set; }

        public double NextYearAirTonnageObjective { get; set; }

        public double CurrentYearOceanTeutotal { get; set; }

        public double CurrentYearOceanTeushare { get; set; }

        public double NextYearOceanTeuobjective { get; set; }

        public string? MajorProducts { get; set; }

        public string? DigitalAddress { get; set; }

        public string? Whatsapp { get; set; }
    }
}
