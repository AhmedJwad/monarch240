using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalApp
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public string? Time { get; set; }

    /// <summary>
    /// 校准项目名
    /// </summary>
    public string? TestName { get; set; }

    /// <summary>
    /// 1、空白 2、量程 3、两点 4、全点
    /// </summary>
    public int? CalType { get; set; }

    /// <summary>
    /// 标准液序号
    /// </summary>
    public byte? StdId { get; set; }

    /// <summary>
    /// 测试次数
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
    /// 正常样本量(稀释用的样本量)
    /// </summary>
    public string? Sample { get; set; }

    /// <summary>
    /// 稀释后分析用的样本量
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
    /// 1申请、2测试、3完成
    /// </summary>
    public short? Flag { get; set; }

    public bool? Dilute { get; set; }

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
