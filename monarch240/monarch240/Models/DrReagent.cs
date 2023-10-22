using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrReagent
{
    /// <summary>
    /// 唯一试剂编号
    /// </summary>
    public int ReaId { get; set; }

    /// <summary>
    /// 试剂名称
    /// </summary>
    public string? ReaName { get; set; }

    /// <summary>
    /// 试剂盘号
    /// </summary>
    public short? ReaDisk { get; set; }

    /// <summary>
    /// 试剂位置
    /// </summary>
    public short? ReaPosition { get; set; }

    /// <summary>
    /// 试剂类型
    /// </summary>
    public string? ReaType { get; set; }

    /// <summary>
    /// 试剂瓶号
    /// </summary>
    public string? ReaBottleNo { get; set; }

    /// <summary>
    /// 试剂批号
    /// </summary>
    public string? ReaLotNo { get; set; }

    /// <summary>
    /// 试剂瓶的规格
    /// </summary>
    public string? ReaBottleSize { get; set; }

    /// <summary>
    /// 试剂剩余量
    /// </summary>
    public string? ReaRemain { get; set; }

    /// <summary>
    /// 试剂剩余测试次数
    /// </summary>
    public short? ReaTimes { get; set; }

    /// <summary>
    /// 试剂有效期
    /// </summary>
    public string? ReaDate { get; set; }

    /// <summary>
    /// 试剂有效天数
    /// </summary>
    public string? ReaDays { get; set; }

    /// <summary>
    /// 备用信息字段
    /// </summary>
    public string? ReaStandby { get; set; }

    public string? ReaBarcode { get; set; }

    public bool? Use { get; set; }

    public string? BackStr1 { get; set; }

    public string? BackStr2 { get; set; }

    public int? BackInt1 { get; set; }

    public int? BackInt2 { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
