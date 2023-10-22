using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrRanPara
{
    public int RanId { get; set; }

    /// <summary>
    /// 检测项目
    /// </summary>
    public string? RanTestName { get; set; }

    /// <summary>
    /// 血清类别
    /// </summary>
    public int? RanSerType { get; set; }

    /// <summary>
    /// 血清范围1年龄
    /// </summary>
    public byte? RanSerAge1 { get; set; }

    /// <summary>
    /// 血清范围2年龄
    /// </summary>
    public byte? RanSerAge2 { get; set; }

    /// <summary>
    /// 血清范围3年龄
    /// </summary>
    public byte? RanSerAge3 { get; set; }

    public byte? RanSerAge1End { get; set; }

    public byte? RanSerAge2End { get; set; }

    public byte? RanSerAge3End { get; set; }

    /// <summary>
    /// 血清范围1男低值
    /// </summary>
    public string? RanSerAge1Ml { get; set; }

    /// <summary>
    /// 血清范围1男高值
    /// </summary>
    public string? RanSerAge1Mh { get; set; }

    /// <summary>
    /// 血清范围1女低值
    /// </summary>
    public string? RanSerAge1Fl { get; set; }

    /// <summary>
    /// 血清范围1女高值
    /// </summary>
    public string? RanSerAge1Fh { get; set; }

    /// <summary>
    /// 血清范围2男低值
    /// </summary>
    public string? RanSerAge2Ml { get; set; }

    /// <summary>
    /// 血清范围2男高值
    /// </summary>
    public string? RanSerAge2Mh { get; set; }

    /// <summary>
    /// 血清范围2女低值
    /// </summary>
    public string? RanSerAge2Fl { get; set; }

    /// <summary>
    /// 血清范围2女高值
    /// </summary>
    public string? RanSerAge2Fh { get; set; }

    /// <summary>
    /// 血清范围3男低值
    /// </summary>
    public string? RanSerAge3Ml { get; set; }

    /// <summary>
    /// 血清范围3男高值
    /// </summary>
    public string? RanSerAge3Mh { get; set; }

    /// <summary>
    /// 血清范围3女低值
    /// </summary>
    public string? RanSerAge3Fl { get; set; }

    /// <summary>
    /// 血清范围3女高值
    /// </summary>
    public string? RanSerAge3Fh { get; set; }

    /// <summary>
    /// 血清参考范围标志
    /// </summary>
    public bool? RanSerRangeFlag { get; set; }

    /// <summary>
    /// 血清默认范围标志
    /// </summary>
    public bool? RanSerDefFlag { get; set; }

    /// <summary>
    /// 血清默认范围低
    /// </summary>
    public string? RanSerDefL { get; set; }

    /// <summary>
    /// 血清默认范围高
    /// </summary>
    public string? RanSerDefH { get; set; }

    /// <summary>
    /// 血清线性范围低值
    /// </summary>
    public string? RanSerLineL { get; set; }

    /// <summary>
    /// 血清线性范围高值
    /// </summary>
    public string? RanSerLineH { get; set; }

    /// <summary>
    /// 0,无范围参数,1有范围参数
    /// </summary>
    public short? RanFlag { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
