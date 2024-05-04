using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Campaign
{
    public int CampaignId { get; set; }

    public int SubscriberId { get; set; }

    public string? CampaignOwnerName { get; set; }

    public int CampaignOwnerUserIdGlobal { get; set; }

    public string CampaignName { get; set; } = null!;

    public string? CampaignNumber { get; set; }

    public string? CampaignStatus { get; set; }

    public string? CampaignType { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedUserIdGlobal { get; set; }

    public string? DeletedUserName { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime LastUpdate { get; set; }

    public int SortOrder { get; set; }

    public DateTime? StartDate { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;
}
