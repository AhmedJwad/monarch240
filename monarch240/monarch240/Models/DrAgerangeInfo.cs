using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrAgerangeInfo
{
    public int Id { get; set; }

    public string? TestName { get; set; }

    public int? SampleType { get; set; }

    public int? Age1 { get; set; }

    public int? Age2 { get; set; }

    public int? Unit { get; set; }

    public string? Ml { get; set; }

    public string? Mh { get; set; }

    public string? Fl { get; set; }

    public string? Fh { get; set; }
}
