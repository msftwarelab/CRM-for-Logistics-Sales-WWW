using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class CompanyLane
{
    public int CompanyLaneId { get; set; }

    public int GlobalCompanyId { get; set; }

    public int SubscriberId { get; set; }

    public string? Comments { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool Deleted { get; set; }

    public int DeletedByIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public string? DestinationCountryCode { get; set; }

    public string? DestinationCountryName { get; set; }

    public string? DestinationIataCode { get; set; }

    public string? DestinationName { get; set; }

    public string? DestinationRegionCode { get; set; }

    public string? DestinationRegionName { get; set; }

    public string? DestinationUnlocoCode { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? Mode { get; set; }

    public string? OriginCountryCode { get; set; }

    public string? OriginCountryName { get; set; }

    public string? OriginIataCode { get; set; }

    public string? OriginName { get; set; }

    public string? OriginRegionCode { get; set; }

    public string? OriginRegionName { get; set; }

    public string? OriginUnlocoCode { get; set; }

    public string? Service { get; set; }

    public string? ShipperCompany { get; set; }

    public string? UpdateUserName { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string? TargetShippingFrequency { get; set; }

    public double TargetVolumeAmount { get; set; }

    public string? TargetVolumeUnit { get; set; }

    public string? TotalShippingFrequency { get; set; }

    public double TotalVolumeAmount { get; set; }

    public string? TotalVolumeUnit { get; set; }

    public bool RequiredLt { get; set; }

    public bool IsIncumbent { get; set; }

    public bool IsTarget { get; set; }

    public string? Incumbent { get; set; }

    public int Rfqmonth { get; set; }

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string? CustomerName { get; set; }

    public string? AccountOwner { get; set; }

    public string? ConsigneeCompany { get; set; }

    public double CurrentRate { get; set; }

    public string? Competitors { get; set; }

    public bool FuelSurchargeIncluded { get; set; }
}
