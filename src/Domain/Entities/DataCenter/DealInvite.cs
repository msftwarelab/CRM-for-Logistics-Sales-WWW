using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class DealInvite
{
    public int DealInviteId { get; set; }

    public int? SubscriberId { get; set; }

    public DateTime? DateInviteSent { get; set; }

    public int? DealId { get; set; }

    public Guid? DealInviteToken { get; set; }

    public string? DealName { get; set; }

    public DateTime? InviteAcceptedDate { get; set; }

    public string? InvitedBySalesRepCode { get; set; }

    public int? InvitedByUserId { get; set; }

    public string? InvitedByUserName { get; set; }

    public string? InviteeEmail { get; set; }

    public string? InviteeName { get; set; }

    public string? InviteePhoneNumber { get; set; }

    public string? InviteeSalesRepCode { get; set; }

    public string? InviteeType { get; set; }

    public int? InviteeUserId { get; set; }

    public virtual Subscriber? Subscriber { get; set; }
}
