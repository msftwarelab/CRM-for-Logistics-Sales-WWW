using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserId { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedUserId { get; set; }

    public string? DeletedUserName { get; set; }

    public string? Description { get; set; }

    public bool IsCustomer { get; set; }

    public DateTime LastUpdate { get; set; }

    public int SubscriberId { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public int UpdateUserId { get; set; }

    public string UserRole1 { get; set; } = null!;
}
