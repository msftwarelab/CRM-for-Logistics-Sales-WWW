using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class LinkGlobalSuscriberToSubscriber
{
    public int LinkGlobalSubscriberToSubscriberId { get; set; }

    public int GlobalSubscriberId { get; set; }

    public int LinkedSubscriberId { get; set; }

    public string? DataCenter { get; set; }
}
