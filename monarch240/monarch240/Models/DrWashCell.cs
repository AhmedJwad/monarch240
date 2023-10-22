using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrWashCell
{
    public int CelId { get; set; }

    /// <summary>
    /// 测试项目
    /// </summary>
    public string? CelName { get; set; }

    /// <summary>
    /// R1针的清洁剂类型
    /// </summary>
    public string? CelR1WashType { get; set; }

    /// <summary>
    /// R1针的清洁剂使用量
    /// </summary>
    public short? CelR1Volume { get; set; }

    /// <summary>
    /// R2针的清洁剂类型
    /// </summary>
    public string? CelR2WashType { get; set; }

    /// <summary>
    /// R2针的清洁剂使用量
    /// </summary>
    public short? CelR2Volume { get; set; }
}
