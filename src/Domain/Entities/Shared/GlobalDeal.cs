using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GlobalDeal
{
    public int DealIdGlobal { get; set; }

    public int DealId { get; set; }

    public int SubscriberId { get; set; }

    public string? Campaign { get; set; }

    public double Cbms { get; set; }

    public double CbmsSpot { get; set; }

    public int CompanyId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public string? CompanyName { get; set; }

    public string? Comments { get; set; }

    public string? Commodities { get; set; }

    public string? Competitors { get; set; }

    public string? CommissionType { get; set; }

    public DateTime? CommissionStartDate { get; set; }

    public string? ConsigneeNames { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public DateTime? ContractStartDate { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public DateTime? DateLost { get; set; }

    public DateTime? DateProposalDue { get; set; }

    public DateTime? DateWon { get; set; }

    public string? DataCenter { get; set; }

    public string? DealCountryName { get; set; }

    public string? DealDescription { get; set; }

    public string? DealName { get; set; }

    public string? DealNumber { get; set; }

    public int DealOwnerUserId { get; set; }

    public int DealOwnerIdGlobal { get; set; }

    public string? DealOwnerName { get; set; }

    public string? DealType { get; set; }

    public DateTime? DecisionDate { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserId { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public string? DestinationLocations { get; set; }

    public string? DestinationCountries { get; set; }

    public string? DestinationRegions { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public string? DealSource { get; set; }

    public DateTime? EstimatedStartDate { get; set; }

    public string? Incoterms { get; set; }

    public string Industry { get; set; } = null!;

    public double Kgs { get; set; }

    public double KgsSpot { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public double Lbs { get; set; }

    public double LbsSpot { get; set; }

    public string? LocationCode { get; set; }

    public int LocationId { get; set; }

    public string? LocationName { get; set; }

    public DateTime? NextActivityDate { get; set; }

    public string? OrignLocations { get; set; }

    public string? OrignCountries { get; set; }

    public string? OrignRegions { get; set; }

    public int PrimaryContactId { get; set; }

    public string PrimaryContactName { get; set; } = null!;

    public double Profit { get; set; }

    public double ProfitPercentage { get; set; }

    public double ProfitUsdspot { get; set; }

    public double ProfitUsd { get; set; }

    public string? ReasonWonLost { get; set; }

    public string? RegionCode { get; set; }

    public string? RegionName { get; set; }

    public double Revenue { get; set; }

    public double RevenueUsd { get; set; }

    public double RevenueUsdspot { get; set; }

    public int SalesStageId { get; set; }

    public string SalesStageName { get; set; } = null!;

    public string? SalesTeam { get; set; }

    public string? Services { get; set; }

    public string? ShipperNames { get; set; }

    public string? SourceDataCenter { get; set; }

    public int? SourceDataCenterDealId { get; set; }

    public int? SourceSubscriberId { get; set; }

    public bool SpotDeal { get; set; }

    public string? Tags { get; set; }

    public double Teus { get; set; }

    public double TeusSpot { get; set; }

    public double Tonnes { get; set; }

    public double TonnesSpot { get; set; }

    public int UpdateUserId { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public double WonExchangeRate { get; set; }

    public DateTime? TransferredDate { get; set; }

    public double Feus { get; set; }

    public double FeusSpot { get; set; }

    public double Trucks { get; set; }

    public double TrucksSpot { get; set; }

    public DateTime? LastExchangeRateAppliedDate { get; set; }

    public int ConversionGlobalDealId { get; set; }

    public string? ConversionGlobalDealDataCenter { get; set; }

    public int PrimaryContactIdGlobal { get; set; }

    public int CopiedGlobalDealId { get; set; }
}
