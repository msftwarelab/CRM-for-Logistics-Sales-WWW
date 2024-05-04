using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class EmailAttachment
{
    public int EmailAttachmentId { get; set; }

    public int? SubscriberId { get; set; }

    public int? ContentLength { get; set; }

    public string? ContentType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedUserId { get; set; }

    public string? CreatedUserName { get; set; }

    public int? EmailId { get; set; }

    public string? FileName { get; set; }

    public int? UserId { get; set; }
}
