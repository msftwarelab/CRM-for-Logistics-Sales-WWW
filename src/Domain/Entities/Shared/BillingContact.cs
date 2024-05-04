using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class BillingContact
{
    public int BillingContactId { get; set; }

    public int BillingEntityId { get; set; }

    public int CreatedById { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public bool Deleted { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int DeletedBy { get; set; }

    public string? DeletedByName { get; set; }

    public string? EmailAddress { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public string? UpdateUserName { get; set; }

    public int UpdateUserId { get; set; }

    public string? ToCc { get; set; }

    public bool IsPrimaryContact { get; set; }
}
