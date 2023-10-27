using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrPatient
{
    /// <summary>
    /// 唯一患者流水号
    /// </summary>
    public int PatId { get; set; }

    /// <summary>
    /// 患者编号，同样本编号
    /// </summary>
    public int? PatTestNo { get; set; }

    /// <summary>
    /// 样本盘
    /// </summary>
    public string? PatDisk { get; set; }

    /// <summary>
    /// 样本位置
    /// </summary>
    public string? PatPosition { get; set; }

    /// <summary>
    /// 样本条形码号
    /// </summary>
    public string? PatBarcode { get; set; }

    /// <summary>
    /// 病历号
    /// </summary>
    public string? PatCaseNo { get; set; }

    /// <summary>
    /// 患者类型：常规、急诊
    /// </summary>
    public string? PatType { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string? PatName { get; set; }

    /// <summary>
    /// 性别
    /// </summary>
    public string? PatSex { get; set; }

    /// <summary>
    /// 年龄
    /// </summary>
    public string? PatAge { get; set; }

    /// <summary>
    /// 年龄单位
    /// </summary>
    public string? PatAgeUnit { get; set; }

    /// <summary>
    /// 科室
    /// </summary>
    public string? PatRoom { get; set; }

    /// <summary>
    /// 床号
    /// </summary>
    public string? PatBedNo { get; set; }

    /// <summary>
    /// 样本种类
    /// </summary>
    public int? PatSampleType { get; set; }

    /// <summary>
    /// 稀释
    /// </summary>
    public bool? PatDilute { get; set; }

    /// <summary>
    /// 样本体积
    /// </summary>
    public short? PatVolume { get; set; }

    /// <summary>
    /// 杯类型
    /// </summary>
    public short? PatCupType { get; set; }

    /// <summary>
    /// 组合项目
    /// </summary>
    public string? PatProfile { get; set; }

    /// <summary>
    /// 送检日期
    /// </summary>
    public DateTime? PatSendingDate { get; set; }

    /// <summary>
    /// 检验日期
    /// </summary>
    public DateTime? PatTestingDate { get; set; }

    /// <summary>
    /// 报告日期
    /// </summary>
    public DateTime? PatReportDate { get; set; }

    public DateTime? PatTestTime { get; set; }

    /// <summary>
    /// 送检医师
    /// </summary>
    public string? PatDoctor { get; set; }

    /// <summary>
    /// 检验医师
    /// </summary>
    public string? PatChecker { get; set; }

    /// <summary>
    /// 审核医师
    /// </summary>
    public string? PatAssessor { get; set; }

    /// <summary>
    /// 临床诊断
    /// </summary>
    public string? PatClinic { get; set; }

    /// <summary>
    /// 备注信息
    /// </summary>
    public string? PatRemark { get; set; }

    /// <summary>
    /// 审核信息
    /// </summary>
    public short? PatAuditingInfo { get; set; }

    /// <summary>
    /// 打印信息
    /// </summary>
    public short? PatPrintInfo { get; set; }

    /// <summary>
    /// 结果信息
    /// </summary>
    public short? PatResultInfo { get; set; }

    /// <summary>
    /// 备用字段
    /// </summary>
    public string? PatStandBy { get; set; }

    /// <summary>
    /// 是否急诊
    /// </summary>
    public bool? PatFlag { get; set; }

    /// <summary>
    /// 0未扫描，1已扫描
    /// </summary>
    public byte? PatBarFlag { get; set; }

    public short? PatRepeatCount { get; set; }

    public bool? PatSerumFlag { get; set; }

    public string? PatProfileItems { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public bool? BFlag { get; set; }

    public DateTime? PatSendingTime { get; set; }

    public DateTime? PatReportTime { get; set; }

    public DateTime? PatSamplingDate { get; set; }

    public DateTime? PatSamplingTime { get; set; }

    
}
