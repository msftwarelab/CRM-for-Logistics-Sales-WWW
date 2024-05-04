using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.DataCenter;

public partial class DocumentType
{
    public int Id { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentTypeText { get; set; }

    public bool DeleteExisting { get; set; }
}
