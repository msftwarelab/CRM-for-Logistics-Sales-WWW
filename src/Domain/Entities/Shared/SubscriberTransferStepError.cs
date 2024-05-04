using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class SubscriberTransferStepError
{
    public int SubscriberTransferStepErrorId { get; set; }

    public int SubscriberTransferStepId { get; set; }

    public string? Error { get; set; }

    public int RefId { get; set; }

    public string? RefType { get; set; }

    public virtual SubscriberTransferStep SubscriberTransferStep { get; set; } = null!;
}
