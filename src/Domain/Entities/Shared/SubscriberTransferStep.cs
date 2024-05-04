using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class SubscriberTransferStep
{
    public int SubscriberTransferStepId { get; set; }

    public int SubscriberTransferId { get; set; }

    public int Step { get; set; }

    public string? StepStr { get; set; }

    public DateTime? StartedDate { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int TotalFound { get; set; }

    public int TotalTransferredCount { get; set; }

    public int ErrorCount { get; set; }

    public bool Completed { get; set; }

    public virtual SubscriberTransfer SubscriberTransfer { get; set; } = null!;

    public virtual ICollection<SubscriberTransferStepError> SubscriberTransferStepErrors { get; set; } = new List<SubscriberTransferStepError>();
}
