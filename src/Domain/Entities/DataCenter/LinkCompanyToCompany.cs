using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class LinkCompanyToCompany
{
    public int LinkCompanyToCompanyId { get; set; }

    public int SubscriberId { get; set; }

    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public int LinkedCompanyId { get; set; }

    public string LinkedCompanyName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string LinkType { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int CompanyIdGlobal { get; set; }

    public int LinkedCompanyIdGlobal { get; set; }
}
