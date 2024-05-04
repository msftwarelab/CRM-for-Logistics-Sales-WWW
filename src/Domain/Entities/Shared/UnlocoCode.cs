using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class UnlocoCode
{
    public int UnlocoCodeId { get; set; }

    public string? UnlocoCode1 { get; set; }

    public bool? Active { get; set; }

    public bool Airport { get; set; }

    public bool BorderCrossing { get; set; }

    public string? Coordinates { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public int? CreatedById { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }

    public bool FixedTransport { get; set; }

    public bool FunctionNotKnown { get; set; }

    public string? IataCode { get; set; }

    public bool InlandPort { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LocationDate { get; set; }

    public string? LocationFunction { get; set; }

    public string? LocationName { get; set; }

    public string? LocationNameWithDiacriticals { get; set; }

    public bool Multimodal { get; set; }

    public bool PostalExchangeOffice { get; set; }

    public bool RailTerminal { get; set; }

    public bool RoadTerminal { get; set; }

    public bool Seaport { get; set; }

    public string? SubdivisionCode { get; set; }

    public int? UpdateUserId { get; set; }

    public string? UpdateUserName { get; set; }

    public bool MatchesPortCode { get; set; }

    public string? PortName { get; set; }
}
