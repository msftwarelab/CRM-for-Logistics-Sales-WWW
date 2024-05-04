using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class ContactType
{
    public int ContactTypeId { get; set; }

    public int SubscriberId { get; set; }

    public string ContactTypeName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime LastUpdate { get; set; }

    public int SortOrder { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UpdateUserId { get; set; }
}
