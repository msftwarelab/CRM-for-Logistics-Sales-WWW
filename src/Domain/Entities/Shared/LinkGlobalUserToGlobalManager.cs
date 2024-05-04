using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkGlobalUserToGlobalManager
{
    public int LinkGlobalUserToGlobalManagerId { get; set; }

    public int CreatedGlobalUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool Deleted { get; set; }

    public int? DeletedUserId { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? ManagerName { get; set; }

    public string? ManagerType { get; set; }

    public int ManagerGlobalUserId { get; set; }

    public int ManagerGlobalUserSubscriberId { get; set; }

    public int GlobalUserId { get; set; }

    public int GlobalUserSubscriberId { get; set; }

    public string? UserName { get; set; }

    public string? UserRole { get; set; }

    public string? UpdateUserName { get; set; }

    public int UpdateGlobalUserId { get; set; }
}
