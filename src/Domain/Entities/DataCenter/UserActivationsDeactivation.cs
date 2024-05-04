using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class UserActivationsDeactivation
{
    public int Id { get; set; }

    public int? SubscriberId { get; set; }

    public int? ActivatedByUserId { get; set; }

    public string? ActivatedByUserName { get; set; }

    public DateTime? ActivatedDate { get; set; }

    public int? DeactivatedByUserId { get; set; }

    public string? DeactivatedByUserName { get; set; }

    public DateTime? DeactivatedDate { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }
}
