using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrAlarmInfo
{
    public int AlaId { get; set; }

    public string? AlaCode { get; set; }

    public string? AlaLevel { get; set; }

    public string? AlaName { get; set; }

    public string? AlaDescribe { get; set; }

    public string? AlaPlan { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
