using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalculate
{
    public int CalId { get; set; }

    public string? CalTest { get; set; }

    public string? CalName { get; set; }

    public string? CalUnit { get; set; }

    public short? CalPoint { get; set; }

    /// <summary>
    /// 参考范围低值
    /// </summary>
    public string? CalRangeL { get; set; }

    /// <summary>
    /// 参考范围高值
    /// </summary>
    public string? CalRangeH { get; set; }

    public string? CalFormula { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }
}
