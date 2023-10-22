using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrBoYuan
{
    public int Id { get; set; }

    public string? TestName { get; set; }

    public int? SampleType { get; set; }

    public DateTime? TestDate { get; set; }

    public double? TestValue { get; set; }

    public bool? BFlag { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
