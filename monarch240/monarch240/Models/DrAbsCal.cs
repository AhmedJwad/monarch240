using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrAbsCal
{
    public int Id { get; set; }

    /// <summary>
    /// 测试号
    /// </summary>
    public int? TestId { get; set; }

    public string? TestName { get; set; }

    /// <summary>
    /// 杯号
    /// </summary>
    public int? TestCupNo { get; set; }

    /// <summary>
    /// 圈数
    /// </summary>
    public int? TestCyc { get; set; }

    /// <summary>
    /// 标准液序号
    /// </summary>
    public byte? StdId { get; set; }

    /// <summary>
    /// 次数
    /// </summary>
    public byte? Count { get; set; }

    public int? AdWaveP { get; set; }

    public string? Pvalue { get; set; }

    public int? AdWaveS { get; set; }

    public string? Svalue { get; set; }

    /// <summary>
    /// AD数据的判断标志
    /// </summary>
    public short? ValueFlag { get; set; }

    /// <summary>
    /// 检测日期
    /// </summary>
    public DateTime? TestDate { get; set; }

    /// <summary>
    /// 检测时间
    /// </summary>
    public string? TestTime { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }
}
