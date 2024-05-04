using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class UserEmailLink
{
    public int Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? Guid { get; set; }

    public int UserIdGlobal { get; set; }

    public int? UserSubscriberId { get; set; }

    public DateTime ExpiryDate { get; set; }

    public string? Link { get; set; }
}
