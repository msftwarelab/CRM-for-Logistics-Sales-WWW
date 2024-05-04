using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Airport
{
    public int AirportId { get; set; }

    public string? AirportType { get; set; }

    public string? AirportName { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public string? Continent { get; set; }

    public int? ElevationFeet { get; set; }

    public string? GpsCode { get; set; }

    public string? IataCode { get; set; }

    public string? IdentifierCode { get; set; }

    public string? IsoRegion { get; set; }

    public DateTime? LastUpdated { get; set; }

    public double? Latitude { get; set; }

    public string? LocalCode { get; set; }

    public double? Longitude { get; set; }

    public string? Municipality { get; set; }

    public string? ScheduledService { get; set; }

    public string? UrlHome { get; set; }

    public string? UrlWikipedia { get; set; }
}
