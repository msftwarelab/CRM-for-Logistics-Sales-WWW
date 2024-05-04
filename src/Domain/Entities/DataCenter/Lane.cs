using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Lane
{
    public int LaneId { get; set; }

    public int DealId { get; set; }

    public int SubscriberId { get; set; }

    public string? Comments { get; set; }

    public string? ConsigneeCompany { get; set; }

    public int CreatedUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool Deleted { get; set; }

    public int DeletedById { get; set; }

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

    public string? PartnerAtDestination { get; set; }

    public string? PartnerDestinationCity { get; set; }

    public string? PartnerDestinationCode { get; set; }

    public string? PartnerDestinationContact { get; set; }

    public string? PartnerDestinationCountryCode { get; set; }

    public string? PartnerDestinationEmail { get; set; }

    public string? PartnerDestinationName { get; set; }

    public string? PartnerDestinationNameOther { get; set; }

    public string? PartnerDestinationPhone { get; set; }

    public string? PartnerAtOrigin { get; set; }

    public string? PartnerOriginCity { get; set; }

    public string? PartnerOriginCode { get; set; }

    public string? PartnerOriginContact { get; set; }

    public string? PartnerOriginCountryCode { get; set; }

    public string? PartnerOriginEmail { get; set; }

    public string? PartnerOriginName { get; set; }

    public string? PartnerOriginNameOther { get; set; }

    public string? PartnerOriginPhone { get; set; }

    public double? ProfitAmount { get; set; }

    public double ProfitPercent { get; set; }

    public string? ProfitUnitOfMeasure { get; set; }

    public double Revenue { get; set; }

    public string? Service { get; set; }

    public string? ShipperCompany { get; set; }

    public string? ShippingFrequency { get; set; }

    public double TotalLaneProfit { get; set; }

    public string? UpdateUserName { get; set; }

    public int UpdateUserId { get; set; }

    public double VolumeAmount { get; set; }

    public string? VolumeUnit { get; set; }

    public double RevenueUsd { get; set; }

    public double TotalLaneProfitUsd { get; set; }

    public string? ReceiveFrom3Pl { get; set; }

    public string? ServiceLocation { get; set; }

    public string? SpecialRequirements { get; set; }

    public bool RequiresBarcode { get; set; }

    public bool TrackAndTrace { get; set; }

    public bool CustomerPickUpAtWarehouse { get; set; }

    public string? ConversionLaneDataCenter { get; set; }

    public int ConversionLaneId { get; set; }
}
