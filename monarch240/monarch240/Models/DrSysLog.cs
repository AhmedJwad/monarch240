using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrSysLog
{
    public int LogId { get; set; }

    public DateTime? LogDate { get; set; }

    public string? LogOperater { get; set; }

    public string? LogEvent { get; set; }

    public short? LogType { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }
}
