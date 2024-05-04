using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class Message
{
    public int MessageId { get; set; }

    public int SubscriberId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedUserIdGlobal { get; set; }

    public string CreatedUserName { get; set; } = null!;

    public string? MessageType { get; set; }

    public int? MessageFilterDealId { get; set; }

    public int? MessageFilterCompanyIdGlobal { get; set; }

    public int? MessageFilterContactId { get; set; }

    public string? MessageFilterData { get; set; }

    public string MessageContent { get; set; } = null!;

    public string? MessageContentType { get; set; }

    public string? MessageEmailData { get; set; }

    public int MessageToUserIdGlobal { get; set; }

    public string MessageToUserName { get; set; } = null!;

    public string? MessageCcglobalUsers { get; set; }

    public bool MessageSentDeleted { get; set; }

    public DateTime? MessageSentDeletedDate { get; set; }

    public int? MessageSentDeletedUserIdGlobal { get; set; }

    public string? MessageSentDeletedUserName { get; set; }

    public string? MessageReceviedDeletedGlobalUsers { get; set; }

    public string? MessageGuid { get; set; }

    public int UpdateUserIdGlobal { get; set; }

    public string UpdateUserName { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public int UserId { get; set; }

    public int UserIdGlobal { get; set; }

    public string UserName { get; set; } = null!;

    public int MessageFilterGlobalContactId { get; set; }
}
