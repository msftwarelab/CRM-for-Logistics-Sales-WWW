using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GlobalCompanyAccessRequest
{
    public int Id { get; set; }

    public string Guid { get; set; } = null!;

    public int RequestedGlobalUserId { get; set; }

    public int GlobalCompanyId { get; set; }

    public int CompanyOwnerId { get; set; }

    public bool Accepted { get; set; }

    public DateTime? AcceptedDate { get; set; }

    public DateTime? RequestedDate { get; set; }
}
