using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class LinkUserToManager
{
    public int LinkUserToManagerId { get; set; }

    public int SubscriberId { get; set; }

    public int CreatedUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool Deleted { get; set; }

    public int? DeletedUserId { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? ManagerName { get; set; }

    public string? ManagerType { get; set; }

    public int ManagerUserId { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserRole { get; set; }

    public string? UpdateUserName { get; set; }

    public int UpdateUserId { get; set; }
}
