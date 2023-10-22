using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrAnaPara
{
    public int AnaTestId { get; set; }

    /// <summary>
    /// 测试项目名称
    /// </summary>
    public string? AnaTestName { get; set; }

    /// <summary>
    /// 单位
    /// </summary>
    public string? AnaTestUnit { get; set; }

    /// <summary>
    /// 小数位数
    /// </summary>
    public short? AnaTestDigits { get; set; }

    /// <summary>
    /// 报告单名称
    /// </summary>
    public string? AnaTestReportName { get; set; }

    /// <summary>
    /// 质控品间隔
    /// </summary>
    public string? AnaTestQcTimes { get; set; }

    /// <summary>
    /// 测试方法
    /// </summary>
    public int? AnaTestMeans { get; set; }

    /// <summary>
    /// 测试时间
    /// </summary>
    public string? AnaTestTime { get; set; }

    /// <summary>
    /// 测试点1
    /// </summary>
    public short? AnaTestPoint1 { get; set; }

    /// <summary>
    /// 测试点2
    /// </summary>
    public short? AnaTestPoint2 { get; set; }

    /// <summary>
    /// 测试点3
    /// </summary>
    public short? AnaTestPoint3 { get; set; }

    /// <summary>
    /// 测试点4
    /// </summary>
    public short? AnaTestPoint4 { get; set; }

    /// <summary>
    /// 测试主波长
    /// </summary>
    public short? AnaWaveP { get; set; }

    /// <summary>
    /// 测试副波长
    /// </summary>
    public short? AnaWaveS { get; set; }

    /// <summary>
    /// 稀释液的位置
    /// </summary>
    public short? AnaDiluentPos { get; set; }

    /// <summary>
    /// 仪器因数a
    /// </summary>
    public string? AnaTestFactorA { get; set; }

    /// <summary>
    /// 仪器因数b
    /// </summary>
    public string? AnaTestFactorB { get; set; }

    /// <summary>
    /// 样本类型1
    /// </summary>
    public int? AnaTestType1 { get; set; }

    /// <summary>
    /// 样本类型2
    /// </summary>
    public int? AnaTestType2 { get; set; }

    /// <summary>
    /// 样品杯常量时，类别1需稀释的样品量
    /// </summary>
    public string? AnaClass1Nor1 { get; set; }

    /// <summary>
    /// 样品杯常量时，类别1稀释后分析用的样品量
    /// </summary>
    public string? AnaClass1Nor2 { get; set; }

    /// <summary>
    /// 样品杯常量时，类别1稀释液的量
    /// </summary>
    public string? AnaClass1Nor3 { get; set; }

    /// <summary>
    /// 减量时......
    /// </summary>
    public string? AnaClass1Dec1 { get; set; }

    /// <summary>
    /// 减量时......
    /// </summary>
    public string? AnaClass1Dec2 { get; set; }

    /// <summary>
    /// 减量时......
    /// </summary>
    public string? AnaClass1Dec3 { get; set; }

    /// <summary>
    /// 增量时......
    /// </summary>
    public string? AnaClass1Inc1 { get; set; }

    /// <summary>
    /// 增量时......
    /// </summary>
    public string? AnaClass1Inc2 { get; set; }

    /// <summary>
    /// 增量时......
    /// </summary>
    public string? AnaClass1Inc3 { get; set; }

    /// <summary>
    /// 样品杯常量时，类别2需稀释的样品量
    /// </summary>
    public string? AnaClass2Nor1 { get; set; }

    /// <summary>
    /// 样品杯常量时，类别2稀释后测试用的样品量
    /// </summary>
    public string? AnaClass2Nor2 { get; set; }

    /// <summary>
    /// 样品杯常量时，类别2稀释液的量
    /// </summary>
    public string? AnaClass2Nor3 { get; set; }

    /// <summary>
    /// 减量时......
    /// </summary>
    public string? AnaClass2Dec1 { get; set; }

    /// <summary>
    /// 减量时......
    /// </summary>
    public string? AnaClass2Dec2 { get; set; }

    /// <summary>
    /// 减量时......
    /// </summary>
    public string? AnaClass2Dec3 { get; set; }

    /// <summary>
    /// 增量时......
    /// </summary>
    public string? AnaClass2Inc1 { get; set; }

    /// <summary>
    /// 增量时......
    /// </summary>
    public string? AnaClass2Inc2 { get; set; }

    /// <summary>
    /// 增量时......
    /// </summary>
    public string? AnaClass2Inc3 { get; set; }

    /// <summary>
    /// Class1的反应界限吸光度
    /// </summary>
    public string? AnaClass1Abs { get; set; }

    /// <summary>
    /// Class2的反应界限吸光度
    /// </summary>
    public string? AnaClass2Abs { get; set; }

    /// <summary>
    /// Class1的前带界限值
    /// </summary>
    public string? AnaClass1Prozone { get; set; }

    /// <summary>
    /// Class2的前带界限值
    /// </summary>
    public string? AnaClass2Prozone { get; set; }

    /// <summary>
    /// 反应界限吸光度类型
    /// </summary>
    public int? AnaAbsType { get; set; }

    /// <summary>
    /// 前带界限类型
    /// </summary>
    public int? AnaProzoneType { get; set; }

    /// <summary>
    /// R1的试剂量
    /// </summary>
    public short? AnaVolumeR1 { get; set; }

    /// <summary>
    /// R1的位置
    /// </summary>
    public short? AnaPositionR1 { get; set; }

    /// <summary>
    /// R2的试剂量
    /// </summary>
    public short? AnaVolumeR2 { get; set; }

    /// <summary>
    /// R2的位置
    /// </summary>
    public short? AnaPositionR2 { get; set; }

    /// <summary>
    /// R3的试剂量
    /// </summary>
    public short? AnaVolumeR3 { get; set; }

    /// <summary>
    /// R3的位置
    /// </summary>
    public short? AnaPositionR3 { get; set; }

    /// <summary>
    /// R4的试剂量
    /// </summary>
    public short? AnaVolumeR4 { get; set; }

    /// <summary>
    /// R4的位置
    /// </summary>
    public short? AnaPositionR4 { get; set; }

    /// <summary>
    /// 双项目分析后半项目
    /// </summary>
    public string? AnaTwinTest { get; set; }

    /// <summary>
    /// 后半项目测光点1
    /// </summary>
    public short? AnaTwinPoint1 { get; set; }

    /// <summary>
    /// 后半项目测光点2
    /// </summary>
    public short? AnaTwinPoint2 { get; set; }

    /// <summary>
    /// 后半项目测光点3
    /// </summary>
    public short? AnaTwinPoint3 { get; set; }

    /// <summary>
    /// 后半项目测光点4
    /// </summary>
    public short? AnaTwinPoint4 { get; set; }

    /// <summary>
    /// 0,无参数,1有参数
    /// </summary>
    public short? AnaFlag { get; set; }

    public bool? AnaSerum { get; set; }

    public int? AnaVolumeR1dil { get; set; }

    public int? AnaVolumeR2dil { get; set; }

    public int? AnaVolumeR3dil { get; set; }

    public int? AnaVolumeR4dil { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public int? DiluentType { get; set; }

    public string? AnaParaMethod { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
