using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class EmailTemplate
{
    public int EmailTemplateId { get; set; }

    public int TemplateTypeId { get; set; }

    public string? Subject { get; set; }

    public string? Template { get; set; }

    public int RefId { get; set; }
}
