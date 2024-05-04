using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class FreeTrialRequest
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? CountryName { get; set; }

    public string? DataCenter { get; set; }

    public string? EmailAddress { get; set; }

    public string? EmailMessageId { get; set; }

    public string? FullName { get; set; }

    public string? Guid { get; set; }

    public string? IpAddress { get; set; }

    public DateTime RequestedDate { get; set; }

    public int SubscriberId { get; set; }

    public int UserId { get; set; }

    public bool Verified { get; set; }

    public DateTime? VerifiedDate { get; set; }

    public bool Converted { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public string? FreeTrialCurrentStep { get; set; }
}
