using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class CompanyLinkType
{
    public int CompanyLinkTypeId { get; set; }

    public string CompanyLinkTypeName { get; set; } = null!;

    public int SubscriberId { get; set; }
}
