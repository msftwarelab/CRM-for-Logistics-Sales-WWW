using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkCompanyToCompany
{
    public int LinkCompanyToCompanyId { get; set; }

    public int SubscriberId { get; set; }

    public int CompanyIdGlobal { get; set; }

    public string CompanyName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public int LinkedCompanyIdGlobal { get; set; }

    public string LinkedCompanyName { get; set; } = null!;

    public int LinkTypeId { get; set; }

    public string LinkTypeName { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public int UpdatedUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UserId { get; set; }

    public int UserIdGlobal { get; set; }

    public string UserName { get; set; } = null!;

    public bool OwnerApproved { get; set; }

    public string? OwnerApprovalStatus { get; set; }

    public string? OwnerApprovalGuid { get; set; }
}
