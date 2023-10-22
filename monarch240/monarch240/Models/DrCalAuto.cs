using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalAuto
{
    public int Id { get; set; }

    public string? TestName { get; set; }

    /// <summary>
    /// 空白校准超时
    /// </summary>
    public short? BlankTimeout { get; set; }

    /// <summary>
    /// 量程校准超时
    /// </summary>
    public short? SpanTimeout { get; set; }

    /// <summary>
    /// 两点校准超时
    /// </summary>
    public short? TwoTimeout { get; set; }

    /// <summary>
    /// 全点校准超时
    /// </summary>
    public short? AllTimeout { get; set; }

    /// <summary>
    /// 计时的时间
    /// </summary>
    public DateTime? SetTime { get; set; }

    /// <summary>
    /// 定时标志
    /// </summary>
    public short? SetFlag { get; set; }

    public int? Flag { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }
}
