using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class Industry
{
    public int IndustryId { get; set; }

    public int SubscriberId { get; set; }

    public int CreatedUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? DeletedByUserId { get; set; }

    public string? DeletedByUserName { get; set; }

    public string IndustryName { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public int SortOrder { get; set; }

    public int UpdateUserId { get; set; }

    public string UpdateUserName { get; set; } = null!;
}
