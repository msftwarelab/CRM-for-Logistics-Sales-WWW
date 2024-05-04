using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkGlobalCompanyGlobalUser
{
    public int Id { get; set; }

    public int GlobalCompanyId { get; set; }

    public string? GlobalCompanyName { get; set; }

    public int GlobalUserId { get; set; }

    public string? GlobalUserName { get; set; }

    public int CompanySubscriberId { get; set; }

    public int UserSubscriberId { get; set; }

    public string? SalesTeamRole { get; set; }

    public string? LinkType { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public bool Deleted { get; set; }

    public int DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int UpdateUserId { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? UpdateUserName { get; set; }

    public bool InviteAccepted { get; set; }

    public string? InviteStatus { get; set; }

    public string? InviteGuid { get; set; }
}
