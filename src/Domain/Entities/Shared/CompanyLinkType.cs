using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class CompanyLinkType
{
    public int CompanyLinkTypeId { get; set; }

    public string CompanyLinkTypeName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public int SubscriberId { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;
}
