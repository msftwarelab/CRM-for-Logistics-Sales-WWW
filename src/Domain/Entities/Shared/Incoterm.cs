using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Incoterm
{
    public int IncotermId { get; set; }

    public string? Incoterm1 { get; set; }

    public string? CarrierLoadOnTruck { get; set; }

    public string? ExportCustomsDeclaration { get; set; }

    public string? CarriageToPortOfExport { get; set; }

    public string? UnloadTruckInPortOfExport { get; set; }

    public string? LoadingChargesInPortOfExport { get; set; }

    public string? CarriageToPortOfImport { get; set; }

    public string? UnloadingChargesInPortOfImport { get; set; }

    public string? LoadingOnTruckInPortOfIimport { get; set; }

    public string? CarriageToPlaceOfDestination { get; set; }

    public string? Insurance { get; set; }

    public string? ImportCustomsClearance { get; set; }

    public string? ImportTaxes { get; set; }
}
