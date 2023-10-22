using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrWashReagent
{
    /// <summary>
    /// 流水号
    /// </summary>
    public int ProId { get; set; }

    /// <summary>
    /// 受影响的试剂针名字
    /// </summary>
    public string? ProName { get; set; }

    /// <summary>
    /// 从哪个试剂开始
    /// </summary>
    public string? ProFromTest { get; set; }

    /// <summary>
    /// 试剂的类型
    /// </summary>
    public string? ProFromType { get; set; }

    /// <summary>
    /// 到哪个试剂结束
    /// </summary>
    public string? ProToTest { get; set; }

    /// <summary>
    /// 试剂的类型
    /// </summary>
    public string? ProToType { get; set; }

    /// <summary>
    /// 清洁剂的种类
    /// </summary>
    public string? ProWashType { get; set; }

    /// <summary>
    /// 清洁剂的使用量
    /// </summary>
    public short? ProVolume { get; set; }
}
