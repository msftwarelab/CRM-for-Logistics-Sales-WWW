using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class SubscriberTransfer
{
    public int SubscriberTransferId { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int DestinationSubscriberId { get; set; }

    public string? DestinationDataCenter { get; set; }

    public bool EnabledUsers { get; set; }

    public string? Guid { get; set; }

    public string? SourceDataCenter { get; set; }

    public int SourceSubscriberId { get; set; }

    public DateTime StartDate { get; set; }

    public int TransferredAdminUserId { get; set; }

    public virtual ICollection<SubscriberTransferStep> SubscriberTransferSteps { get; set; } = new List<SubscriberTransferStep>();
}
