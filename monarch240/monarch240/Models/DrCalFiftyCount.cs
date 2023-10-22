using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalFiftyCount
{
    public int CalId { get; set; }

    /// <summary>
    /// 项目名字
    /// </summary>
    public string? CalTestName { get; set; }

    /// <summary>
    /// 检准时间
    /// </summary>
    public DateTime? CalTime { get; set; }

    public string? CalS1abs { get; set; }

    public string? CalFactor { get; set; }

    public string? CalA { get; set; }

    public string? CalB { get; set; }

    public string? CalC { get; set; }

    /// <summary>
    /// 1、申请 2、测试 3、完成
    /// </summary>
    public short? CalFlag { get; set; }

    public bool? CalSuccess { get; set; }

    public float? CalStd11 { get; set; }

    public float? CalStd12 { get; set; }

    public float? CalStd21 { get; set; }

    public float? CalStd22 { get; set; }

    public float? CalStd31 { get; set; }

    public float? CalStd32 { get; set; }

    public float? CalStd41 { get; set; }

    public float? CalStd42 { get; set; }

    public float? CalStd51 { get; set; }

    public float? CalStd52 { get; set; }

    public float? CalStd61 { get; set; }

    public float? CalStd62 { get; set; }

    /// <summary>
    /// 内标液电位(mV)
    /// </summary>
    public string? IsEmf { get; set; }

    /// <summary>
    /// 低浓度斜率液电位(mV)
    /// </summary>
    public string? S1Emf { get; set; }

    /// <summary>
    /// 高浓度斜率液电位(mV)
    /// </summary>
    public string? S2Emf { get; set; }

    /// <summary>
    /// 补偿电位(mV)
    /// </summary>
    public string? S3Emf { get; set; }

    /// <summary>
    /// 斜率(mV)
    /// </summary>
    public string? Slope { get; set; }

    /// <summary>
    /// 内标液浓度(测定值)(mmol/L)
    /// </summary>
    public string? IsConc { get; set; }

    /// <summary>
    /// 补偿液浓度测定值(mmol/L)
    /// </summary>
    public string? S3Conc { get; set; }

    /// <summary>
    /// 补偿值(mmol/L)
    /// </summary>
    public string? CValue { get; set; }

    /// <summary>
    /// R1瓶号
    /// </summary>
    public string? R1Rb { get; set; }

    /// <summary>
    /// R1稳定使用期限
    /// </summary>
    public string? R1Obs { get; set; }

    /// <summary>
    /// R2瓶号
    /// </summary>
    public string? R2Rb { get; set; }

    /// <summary>
    /// R2稳定使用期限
    /// </summary>
    public string? R2Obs { get; set; }

    /// <summary>
    /// R3瓶号
    /// </summary>
    public string? R3Rb { get; set; }

    /// <summary>
    /// R3稳定使用期限
    /// </summary>
    public string? R3Obs { get; set; }

    /// <summary>
    /// R4瓶号
    /// </summary>
    public string? R4Rb { get; set; }

    /// <summary>
    /// R4稳定使用期限
    /// </summary>
    public string? R4Obs { get; set; }

    /// <summary>
    /// 操作员
    /// </summary>
    public string? UserName { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
