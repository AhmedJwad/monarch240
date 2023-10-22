using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCupType
{
    public string CupId { get; set; } = null!;

    public string? CupType { get; set; }

    public string? CupHotKey { get; set; }
}
