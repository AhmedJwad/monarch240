using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrKparaInfo
{
    public int Id { get; set; }

    public string? ItemName { get; set; }

    public double? Lpara { get; set; }

    public double? Hpara { get; set; }

    public bool? Used { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
