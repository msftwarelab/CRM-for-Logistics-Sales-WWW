using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class QuotePackage
{
    public int QuotePackageId { get; set; }

    public bool? Crated { get; set; }

    public string? Forkliftable { get; set; }

    public decimal? PackageHeight { get; set; }

    public decimal? PackageLength { get; set; }

    public int? PackageQuantity { get; set; }

    public decimal? PackageWeight { get; set; }

    public string? QuoteCode { get; set; }

    public int? QuoteId { get; set; }

    public bool? Stackable { get; set; }

    public bool? Turnable { get; set; }
}
