using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrQcDresult
{
    public int QcId { get; set; }

    public string? QcPosId { get; set; }

    public string? QcTestName { get; set; }

    public string? QcBatchId { get; set; }

    public DateTime? QcDate { get; set; }

    public string? QcTime { get; set; }

    public string? QcResult { get; set; }

    public int? QcCount { get; set; }

    public string? QcDeviation { get; set; }

    public string? QcError { get; set; }

    public byte? QcFlag { get; set; }

    public string? QcDayX { get; set; }

    public string? QcDaySd { get; set; }

    public string? QcName { get; set; }

    public string? PrintId { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public int? QcDisk { get; set; }
}
