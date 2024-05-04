using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class GoogleSyncLog
{
    public int GoogleSyncLogId { get; set; }

    public int? AppointmentsAddedToCrm { get; set; }

    public int? AppointmentsAddedToSync { get; set; }

    public int? AppointmentsUpdatedInCrm { get; set; }

    public int? AppointmentsUpdatedInSync { get; set; }

    public int? ContactsAddedToCrm { get; set; }

    public int? ContactsAddedToSync { get; set; }

    public int? ContactsUpdatedInCrm { get; set; }

    public int? ContactsUpdatedInSync { get; set; }

    public int? ContactsDeletedInSync { get; set; }

    public int? ContactsDeletedInCrm { get; set; }

    public string? ElapsedTime { get; set; }

    public int? TasksAddedToCrm { get; set; }

    public int? TasksAddedToSync { get; set; }

    public int? TasksUpdatedInCrm { get; set; }

    public int? TasksUpdatedInSync { get; set; }

    public int? SubscriberId { get; set; }

    public DateTime? SyncEndTime { get; set; }

    public DateTime? SyncStartTime { get; set; }

    public string? SyncType { get; set; }

    public int? UserId { get; set; }

    public int? UserIdGlobal { get; set; }

    public string? UserName { get; set; }
}
