using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class SalesManager
{
    public int SalesManagerId { get; set; }

    public int? SubscriberId { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedUserId { get; set; }

    public string? CreatedUserName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationName { get; set; }

    public string? ManagerTitle { get; set; }

    public string? ManagerType { get; set; }

    public string? RegionCode { get; set; }

    public string? RegionName { get; set; }

    public int? UserId { get; set; }

    public int? UpdateUserId { get; set; }

    public string? UpdateUserName { get; set; }

    public virtual Subscriber? Subscriber { get; set; }

    public virtual User? User { get; set; }
}
