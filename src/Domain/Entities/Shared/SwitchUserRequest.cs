using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class SwitchUserRequest
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? Source { get; set; }

    public DateTime SwitchDateTime { get; set; }

    public bool IsLoggedIn { get; set; }

    public int AdminUserId { get; set; }

    public int SwitchToGlobalUserId { get; set; }

    public bool Expired { get; set; }

    public string? SwitchToGlobalUserDataCenter { get; set; }
}
