using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkGlobalUserToManagingCountry
{
    public int Id { get; set; }

    public int GlobalUserId { get; set; }

    public string? CountryName { get; set; }
}
