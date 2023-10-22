using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrBarcode
{
    public int Id { get; set; }

    public string? Barcode { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }
}
