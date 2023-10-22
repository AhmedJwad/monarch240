using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalPara
{
    public int CalId { get; set; }

    /// <summary>
    /// 校准项目
    /// </summary>
    public string? CalTestName { get; set; }

    /// <summary>
    /// 校准方法
    /// </summary>
    public int? CalCalibrateType { get; set; }

    /// <summary>
    /// 项目名字
    /// </summary>
    public string? CalCalibrateName { get; set; }

    /// <summary>
    /// 校准点
    /// </summary>
    public short? CalPoint { get; set; }

    /// <summary>
    /// 量程点
    /// </summary>
    public short? CalSpan { get; set; }

    /// <summary>
    /// 加权系数
    /// </summary>
    public short? CalWeight { get; set; }

    public string? CalConc1 { get; set; }

    public int? CalPosition1 { get; set; }

    public string? CalSample1 { get; set; }

    public string? CalDilVol1 { get; set; }

    public string? CalDiluent1 { get; set; }

    public string? CalConc2 { get; set; }

    public int? CalPosition2 { get; set; }

    public string? CalSample2 { get; set; }

    public string? CalDilVol2 { get; set; }

    public string? CalDiluent2 { get; set; }

    public string? CalConc3 { get; set; }

    public int? CalPosition3 { get; set; }

    public string? CalSample3 { get; set; }

    public string? CalDilVol3 { get; set; }

    public string? CalDiluent3 { get; set; }

    public string? CalConc4 { get; set; }

    public int? CalPosition4 { get; set; }

    public string? CalSample4 { get; set; }

    public string? CalDilVol4 { get; set; }

    public string? CalDiluent4 { get; set; }

    public string? CalConc5 { get; set; }

    public int? CalPosition5 { get; set; }

    public string? CalSample5 { get; set; }

    public string? CalDilVol5 { get; set; }

    public string? CalDiluent5 { get; set; }

    public string? CalConc6 { get; set; }

    public int? CalPosition6 { get; set; }

    public string? CalSample6 { get; set; }

    public string? CalDilVol6 { get; set; }

    public string? CalDiluent6 { get; set; }

    /// <summary>
    /// 允许收敛吸光度
    /// </summary>
    public string? CalSdlimit { get; set; }

    /// <summary>
    /// 允许偏差吸光度
    /// </summary>
    public string? CalDuplicateLimit2 { get; set; }

    /// <summary>
    /// 灵敏度检查下限
    /// </summary>
    public string? CalSensilivityL { get; set; }

    /// <summary>
    /// 灵敏度检查上限
    /// </summary>
    public string? CalIsozymeQ { get; set; }

    /// <summary>
    /// 第一标准液允许吸光度下限
    /// </summary>
    public string? CalS1absL { get; set; }

    /// <summary>
    /// 第一标准液允许吸光度上限
    /// </summary>
    public string? CalS1absH { get; set; }

    /// <summary>
    /// 使用了几个标准液参数
    /// </summary>
    public short? CalUseCount { get; set; }

    /// <summary>
    /// 0,无校准参数,1,有校准参数
    /// </summary>
    public short? CalFlag { get; set; }

    /// <summary>
    /// 空白校准超时
    /// </summary>
    public short? CalBlankTimeout { get; set; }

    /// <summary>
    /// 量程校准超时
    /// </summary>
    public short? CalSpanTimeout { get; set; }

    /// <summary>
    /// 两点校准超时
    /// </summary>
    public short? CalTwoTimeout { get; set; }

    /// <summary>
    /// 全点校准超时
    /// </summary>
    public short? CalAllTimeout { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public int? CalDisk1 { get; set; }

    public int? CalDisk2 { get; set; }

    public int? CalDisk3 { get; set; }

    public int? CalDisk4 { get; set; }

    public int? CalDisk5 { get; set; }

    public int? CalDisk6 { get; set; }
}
