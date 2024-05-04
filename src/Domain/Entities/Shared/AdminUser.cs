using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class AdminUser
{
    public int Id { get; set; }

    public string? Forename { get; set; }

    public string? Surname { get; set; }

    public string? EmailAddress { get; set; }

    public byte[]? PasswordHash { get; set; }

    public byte[]? PasswordSalt { get; set; }

    public string? Guid { get; set; }

    public bool Active { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int LastUpdatedBy { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public bool? Deleted { get; set; }

    public int DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }
}
