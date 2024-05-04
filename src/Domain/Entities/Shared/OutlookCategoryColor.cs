using System;
using System.Collections.Generic;

namespace FirstFreightAPI.Entities.Shared;

public partial class OutlookCategoryColor
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Color { get; set; }

    public string? HexColor { get; set; }

    public string? Rgb { get; set; }
}
