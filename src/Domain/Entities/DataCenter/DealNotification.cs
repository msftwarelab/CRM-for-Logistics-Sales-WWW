using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class DealNotification
{
    public int DealNotificationId { get; set; }

    public int? SubscriberId { get; set; }

    public int? DealId { get; set; }

    public Guid? DealInviteToken { get; set; }

    public string? DealName { get; set; }

    public string? InvitedBySalesRepCode { get; set; }

    public int? InvitedByUserId { get; set; }

    public string? InvitedByUserName { get; set; }

    public string? InviteeEmail { get; set; }

    public string? InviteeName { get; set; }

    public string? InviteePhoneNumber { get; set; }

    public string? InviteeSalesRepCode { get; set; }

    public int? InviteeUserId { get; set; }

    public DateTime? NotificationDate { get; set; }

    public string? NotificationMessage { get; set; }

    public string? NotificationSubject { get; set; }
}
