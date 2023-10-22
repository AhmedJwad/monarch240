using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrChecker
{
    public string CheId { get; set; } = null!;

    public string? CheName { get; set; }

    public string? ChePass { get; set; }

    public string? CheHotKey { get; set; }

    public int? ChePurview { get; set; }

    public bool? CheLoginFlag { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
