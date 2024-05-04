using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkGlobalDealGlobalUser
{
    public int LinkGloablDealGlobalUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public int DealSubscriberId { get; set; }

    public bool Deleted { get; set; }

    public int DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int GlobalDealId { get; set; }

    public string? GlobalDealName { get; set; }

    public int GlobalUserId { get; set; }

    public string? GlobalUserName { get; set; }

    public bool InviteAccepted { get; set; }

    public string? InviteGuid { get; set; }

    public string? InviteStatus { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LinkType { get; set; }

    public string? SalesTeamRole { get; set; }

    public int UserSubscriberId { get; set; }

    public string? UpdateUserName { get; set; }

    public int UpdateUserId { get; set; }
}
