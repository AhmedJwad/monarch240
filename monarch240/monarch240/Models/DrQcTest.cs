using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrQcTest
{
    public int Id { get; set; }

    /// <summary>
    /// 盘号
    /// </summary>
    public short? Disk { get; set; }

    /// <summary>
    /// 位置
    /// </summary>
    public string? PosId { get; set; }

    /// <summary>
    /// 质控批号
    /// </summary>
    public string? BatchId { get; set; }

    /// <summary>
    /// 质控项目名
    /// </summary>
    public string? TestName { get; set; }

    public int? SampleType { get; set; }

    public string? DayX { get; set; }

    public string? DaySd { get; set; }

    public string? QcName { get; set; }

    public bool? QcFlag { get; set; }

    /// <summary>
    /// 0申请、1测试、2完成
    /// </summary>
    public short? Flag { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
