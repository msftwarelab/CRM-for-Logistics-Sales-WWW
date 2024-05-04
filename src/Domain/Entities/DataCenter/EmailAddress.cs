using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class EmailAddress
{
    public int EmailAddressId { get; set; }

    public int? SubscriberId { get; set; }

    public int? ContactId { get; set; }

    public string? ContactName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedUserId { get; set; }

    public string? CreatedUserName { get; set; }

    public string? EmailAddress1 { get; set; }

    public int? UserId { get; set; }
}
