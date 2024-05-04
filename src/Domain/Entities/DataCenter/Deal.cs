using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Deal
{
    public int DealId { get; set; }

    public int SubscriberId { get; set; }

    public string? Campaign { get; set; }

    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Comments { get; set; }

    public string? Commodities { get; set; }

    public string? Competitors { get; set; }

    public string? CommissionType { get; set; }

    public DateTime? CommissionStartDate { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public DateTime? ContractStartDate { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public string? CurrencyCode { get; set; }

    public DateTime? DateLost { get; set; }

    public DateTime? DateProposalDue { get; set; }

    public DateTime? DateWon { get; set; }

    public string? DealCountryName { get; set; }

    public string? DealDescription { get; set; }

    public string? DealName { get; set; }

    public string? DealNumber { get; set; }

    public int DealOwnerId { get; set; }

    public string? DealRequestType { get; set; }

    public string? DealType { get; set; }

    public DateTime? DecisionDate { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public string? DealSource { get; set; }

    public DateTime? EstimatedStartDate { get; set; }

    public string? Incoterms { get; set; }

    public string? Industry { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationName { get; set; }

    public bool Lost { get; set; }

    public DateTime? NextActionDate { get; set; }

    public string? NextActionStep { get; set; }

    public int PrimaryContactId { get; set; }

    public string PrimaryContactName { get; set; } = null!;

    public string? Products { get; set; }

    public double ProfitPercentage { get; set; }

    public string? Ranking { get; set; }

    public string? ReasonWonLost { get; set; }

    public string? RegionCode { get; set; }

    public double Revenue { get; set; }

    public string? RegionName { get; set; }

    public int SalesRepId { get; set; }

    public string? SalesRepName { get; set; }

    public int SalesStageId { get; set; }

    public string SalesStageName { get; set; } = null!;

    public string? SalesTeam { get; set; }

    public string? SourceDataCenter { get; set; }

    public int? SourceDataCenterDealId { get; set; }

    public int? SourceSubscriberId { get; set; }

    public string? Tags { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public bool Won { get; set; }

    public double? WonExchangeRate { get; set; }

    public int? ConversionAccountId { get; set; }

    public int? ConversionEntityId { get; set; }

    public string? ConversionEntityName { get; set; }

    public int? ConversionEntityType { get; set; }

    public int? ConversionLeadId { get; set; }

    public int? ConversionOpportunityId { get; set; }

    public int? ConversionOwnerUserId { get; set; }

    public int? ConversionPrimaryContactId { get; set; }

    public string? ConversionSalesRepCode { get; set; }

    public string? ConversionSalesRepName { get; set; }

    public double Cbms { get; set; }

    public double Kgs { get; set; }

    public double Lbs { get; set; }

    public double ProfitUsd { get; set; }

    public double RevenueUsd { get; set; }

    public string? Services { get; set; }

    public double Teus { get; set; }

    public double Tonnes { get; set; }

    public bool SpotDeal { get; set; }

    public double Profit { get; set; }

    public int CompanyIdGlobal { get; set; }

    public DateTime? NextActivityDate { get; set; }

    public double ProfitUsdspot { get; set; }

    public double RevenueUsdspot { get; set; }

    public double CbmsSpot { get; set; }

    public double KgsSpot { get; set; }

    public double LbsSpot { get; set; }

    public double TeusSpot { get; set; }

    public double TonnesSpot { get; set; }

    public string? OriginLocations { get; set; }

    public string? OriginCountries { get; set; }

    public string? OriginRegions { get; set; }

    public string? DestinationLocations { get; set; }

    public string? DestinationCountries { get; set; }

    public string? DestinationRegions { get; set; }

    public string? ShipperNames { get; set; }

    public string? ConsigneeNames { get; set; }

    public int DealOwnerIdGlobal { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public int SalesRepIdGlobal { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string? OrignLocations { get; set; }

    public string? OrignCountries { get; set; }

    public string? OrignRegions { get; set; }

    public double Feus { get; set; }

    public double FeusSpot { get; set; }

    public double Trucks { get; set; }

    public double TrucksSpot { get; set; }

    public int PrimaryContactIdGlobal { get; set; }
}
