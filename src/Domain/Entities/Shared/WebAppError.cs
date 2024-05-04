using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class WebAppError
{
    public int WebAppErrorId { get; set; }

    public string ErrorCallStack { get; set; } = null!;

    public string ErrorCode { get; set; } = null!;

    public DateTime ErrorDateTime { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public string? PageCalledFrom { get; set; }

    public string? RoutineName { get; set; }

    public int SubscriberId { get; set; }

    public string SubscriberName { get; set; } = null!;

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;
}
