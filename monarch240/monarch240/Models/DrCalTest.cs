using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalTest
{
    public int Id { get; set; }

    /// <summary>
    /// 校准项目名
    /// </summary>
    public string? CalTest { get; set; }

    /// <summary>
    /// 1、空白 2、量程 3、两点 4、全点
    /// </summary>
    public int? CalType { get; set; }

    public bool? CalFlag { get; set; }

    public bool? CalDilute { get; set; }

    public int? Flag { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public DateTime? ShelfLife { get; set; }

    public bool? IsCheck { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
