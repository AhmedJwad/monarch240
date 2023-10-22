using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrTestAll
{
    public int Id { get; set; }

    /// <summary>
    /// 排队序列号
    /// </summary>
    public int? TestId { get; set; }

    /// <summary>
    /// 该项目在其它数据表的顺序编号
    /// </summary>
    public int? TestOrder { get; set; }

    /// <summary>
    /// 样本编号
    /// </summary>
    public int? TestNo { get; set; }

    /// <summary>
    /// 测试项目名
    /// </summary>
    public string? TestName { get; set; }

    /// <summary>
    /// 标准液序号
    /// </summary>
    public byte? StdId { get; set; }

    /// <summary>
    /// 第几次测试
    /// </summary>
    public byte? Count { get; set; }

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

    /// <summary>
    /// 正常样本量
    /// </summary>
    public string? Sample { get; set; }

    /// <summary>
    /// 分析用的样本量
    /// </summary>
    public string? Analysis { get; set; }

    /// <summary>
    /// 稀释液量
    /// </summary>
    public short? Diluent { get; set; }

    /// <summary>
    /// 稀释液位置
    /// </summary>
    public short? DilPos { get; set; }

    /// <summary>
    /// 试剂1位置
    /// </summary>
    public short? Reg1Pos { get; set; }

    /// <summary>
    /// 试剂2位置
    /// </summary>
    public short? Reg2Pos { get; set; }

    /// <summary>
    /// 试剂3位置
    /// </summary>
    public short? Reg3Pos { get; set; }

    /// <summary>
    /// 试剂4位置
    /// </summary>
    public short? Reg4Pos { get; set; }

    /// <summary>
    /// 试剂1吸量
    /// </summary>
    public short? Reg1Vol { get; set; }

    /// <summary>
    /// 试剂2吸量
    /// </summary>
    public short? Reg2Vol { get; set; }

    /// <summary>
    /// 试剂3吸量
    /// </summary>
    public short? Reg3Vol { get; set; }

    /// <summary>
    /// 试剂4吸量
    /// </summary>
    public short? Reg4Vol { get; set; }

    /// <summary>
    /// 测试次数
    /// </summary>
    public short? Rerun { get; set; }

    /// <summary>
    /// 0、常规 1、急诊 2、质控 3、校准
    /// </summary>
    public short? TestType { get; set; }

    public string? CalType { get; set; }

    /// <summary>
    /// 0申请、1测试、2完成
    /// </summary>
    public short? Flag { get; set; }

    /// <summary>
    /// 稀释
    /// </summary>
    public bool? Dilute { get; set; }

    public string? BatchId { get; set; }

    public byte? CupType { get; set; }

    /// <summary>
    /// ISE
    /// </summary>
    public int? Ise { get; set; }

    /// <summary>
    /// 默认0 分类标志，默认0表示手工校准，自动分为定时校准1、批间校准或瓶间校准2；分类标志，默认0表示登记质控，做质控间隔时为1
    /// </summary>
    public byte? TestAutoFlag { get; set; }

    public string? TestName1 { get; set; }

    public bool? SerumFlag { get; set; }

    public short? Reg1Dil { get; set; }

    public short? Reg2Dil { get; set; }

    public short? Reg3Dil { get; set; }

    public short? Reg4Dil { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
