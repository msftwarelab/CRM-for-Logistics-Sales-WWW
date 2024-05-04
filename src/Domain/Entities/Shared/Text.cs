using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Text
{
    public int TextId { get; set; }

    public Guid Guid { get; set; }

    public int SubscriberId { get; set; }

    public int? ActivityId { get; set; }

    public int? ActivitiesMemberId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public bool IsError { get; set; }

    public string? ErrorDetails { get; set; }

    public string? TextType { get; set; }

    public string TextTo { get; set; } = null!;

    public string? TextToName { get; set; }

    public int? TextToUserIdGlobal { get; set; }

    public int? TextToContactId { get; set; }

    public string TextFrom { get; set; } = null!;

    public string? TextFromUserName { get; set; }

    public int? TextFromUserIdGlobal { get; set; }

    public string? TextMessage { get; set; }

    public string? TwillioSid { get; set; }
}
