using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrTestApp
{
    public int Id { get; set; }

    /// <summary>
    /// 样本编号
    /// </summary>
    public int? TestNo { get; set; }

    /// <summary>
    /// 测试项目名
    /// </summary>
    public string? TestName { get; set; }

    public string? TestCnName { get; set; }

    public string? TestResult { get; set; }

    public string? TestRange { get; set; }

    public string? TestUnit { get; set; }

    public string? Hint { get; set; }

    public string? RerunResult { get; set; }

    /// <summary>
    /// 盘号
    /// </summary>
    public short? Disk { get; set; }

    /// <summary>
    /// 位置
    /// </summary>
    public short? Position { get; set; }

    /// <summary>
    /// 日期
    /// </summary>
    public DateTime? TestDate { get; set; }

    /// <summary>
    /// 时间
    /// </summary>
    public string? TestTime { get; set; }

    public int? SampleType { get; set; }

    /// <summary>
    /// 稀释
    /// </summary>
    public bool? Dilute { get; set; }

    /// <summary>
    /// 杯类型
    /// </summary>
    public short? CupType { get; set; }

    /// <summary>
    /// 样本体积
    /// </summary>
    public short? VolType { get; set; }

    /// <summary>
    /// 测试次数
    /// </summary>
    public short? Rerun { get; set; }

    /// <summary>
    /// 0、常规 1、急诊
    /// </summary>
    public short? TestType { get; set; }

    /// <summary>
    /// 0申请、1测试、2完成
    /// </summary>
    public short? Flag { get; set; }

    /// <summary>
    /// 是否复查该项目
    /// </summary>
    public short? Print { get; set; }

    /// <summary>
    /// 是否使用ISE。0不使用。1使用。
    /// </summary>
    public int? Ise { get; set; }

    public string? TestName1 { get; set; }

    public bool? SerumFlag { get; set; }

    public string? SerumResult { get; set; }

    public string? Reason { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public string? DilSoluName { get; set; }

    public double? Absorbance { get; set; }

    public double? ReAbsorbance { get; set; }

    public double? CupBlank { get; set; }

    public double? ReCupBlank { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
