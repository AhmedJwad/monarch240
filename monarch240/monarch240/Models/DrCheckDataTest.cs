using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCheckDataTest
{
    public short CupNo { get; set; }

    public byte? UseCount { get; set; }

    public int? C340 { get; set; }

    public int? C380 { get; set; }

    public int? C405 { get; set; }

    public int? C450 { get; set; }

    public int? C480 { get; set; }

    public int? C505 { get; set; }

    public int? C546 { get; set; }

    public int? C570 { get; set; }

    public int? C600 { get; set; }

    public int? C660 { get; set; }

    public int? C700 { get; set; }

    public int? C750 { get; set; }

    public bool? UseFlag { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
