using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrToHost
{
    public int Id { get; set; }

    public int? HostId { get; set; }

    public int? HostFlag { get; set; }

    public DateTime? HostTestDate { get; set; }

    public string? HostTestTime { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }
}
