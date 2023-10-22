using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrDilSolution
{
    public int Id { get; set; }

    public string? DilTestName { get; set; }

    public string? DilSoluName { get; set; }

    public bool? DilIsDefault { get; set; }

    public int? DilSampleType { get; set; }

    public int? DilVolType { get; set; }

    public string? DilSample { get; set; }

    public string? DilAnalysis { get; set; }

    public string? DilDiluent { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
