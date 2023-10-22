using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrAlarm
{
    public int AlaId { get; set; }

    public string? AlaCode { get; set; }

    public string? AlaLevel { get; set; }

    public string? AlaName { get; set; }

    public DateTime? AlaTime { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public bool? IsHide { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
