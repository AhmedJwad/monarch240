using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrManualItem
{
    public int ManId { get; set; }

    public string? ManTest { get; set; }

    public string? ManName { get; set; }

    public string? ManUnit { get; set; }

    public short? ManPoint { get; set; }

    /// <summary>
    /// 参考范围低值
    /// </summary>
    public string? ManRangeL { get; set; }

    /// <summary>
    /// 参考范围高值
    /// </summary>
    public string? ManRangeH { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }
}
