using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalResultTemp
{
    public int CalId { get; set; }

    public int? Testid { get; set; }

    /// <summary>
    /// 项目名字
    /// </summary>
    public string? CalTestName { get; set; }

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

    public string? CalStd11 { get; set; }

    public string? CalStd12 { get; set; }

    public string? CalStd21 { get; set; }

    public string? CalStd22 { get; set; }

    public string? CalStd31 { get; set; }

    public string? CalStd32 { get; set; }

    public string? CalStd41 { get; set; }

    public string? CalStd42 { get; set; }

    public string? CalStd51 { get; set; }

    public string? CalStd52 { get; set; }

    public string? CalStd61 { get; set; }

    public string? CalStd62 { get; set; }

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

    public string? CalPara1 { get; set; }

    public string? CalPara2 { get; set; }

    public string? CalPara3 { get; set; }

    public string? CalPara4 { get; set; }

    public string? CalPara5 { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
