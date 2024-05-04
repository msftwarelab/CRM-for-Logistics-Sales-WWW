using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkGlobalContactToCompany
{
    public int LinkGlobalContactToCompanyId { get; set; }

    public int SubscriberId { get; set; }

    public int GlobalCompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public int GlobalContactId { get; set; }

    public string ContactName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public string LinkType { get; set; } = null!;

    public int UpdateUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;
}
