using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class ExchangeRatesLog
{
    public int ExchangeRatesLogId { get; set; }

    public string? ElapsedTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? ErrorMessage { get; set; }

    public int? RecordsAdded { get; set; }

    public int? RecordsDeleted { get; set; }

    public int? RecordsExported { get; set; }

    public int? RecordsUpdated { get; set; }

    public string? ReturnMessage { get; set; }

    public string? RoutineName { get; set; }

    public string? RoutineType { get; set; }

    public DateTime? StartTime { get; set; }

    public bool Success { get; set; }
}
