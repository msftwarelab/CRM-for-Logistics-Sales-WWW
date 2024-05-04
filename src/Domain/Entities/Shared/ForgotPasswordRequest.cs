using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class ForgotPasswordRequest
{
    public int Id { get; set; }

    public string? EmailAddress { get; set; }

    public int UserId { get; set; }

    public int SubscriberId { get; set; }

    public string? DataCenter { get; set; }

    public DateTime RequestedDate { get; set; }

    public string? Guid { get; set; }

    public bool Processed { get; set; }

    public int EmailId { get; set; }

    public string? IpAddress { get; set; }
}
