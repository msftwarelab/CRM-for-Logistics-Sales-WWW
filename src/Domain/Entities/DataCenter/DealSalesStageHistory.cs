using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class DealSalesStageHistory
{
    public int DealSalesStageHistoryId { get; set; }

    public int SubscriberId { get; set; }

    public int DealId { get; set; }

    public int SalesStageId { get; set; }

    public DateTime AddedDate { get; set; }

    public int AddedBy { get; set; }

    public string AddedByName { get; set; } = null!;

    public bool Removed { get; set; }

    public int RemovedBy { get; set; }

    public string? RemovedByName { get; set; }

    public DateTime? RemovedDate { get; set; }
}
