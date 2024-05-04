using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class ReassignUserRequest
{
    public int Id { get; set; }

    public int DepartingUserIdGlobal { get; set; }

    public int NewUserIdGlobal { get; set; }

    public string? CurrentProcessingType { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int RequestedUserIdGlobal { get; set; }

    public DateTime RequestedDate { get; set; }

    public int CompaniesFound { get; set; }

    public int CompaniesTransferred { get; set; }

    public int ContactsFound { get; set; }

    public int ContactsTransferred { get; set; }

    public int EventsFound { get; set; }

    public int EventsTransferred { get; set; }

    public int TasksFound { get; set; }

    public int TasksTransferred { get; set; }

    public int DealsFound { get; set; }

    public int DealsTransferred { get; set; }

    public string? Guid { get; set; }
}
