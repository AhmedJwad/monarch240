using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrStatType
{
    public int Id { get; set; }

    /// <summary>
    /// 统计起始时间
    /// </summary>
    public string? FirstDate { get; set; }

    /// <summary>
    /// 统计结束时间
    /// </summary>
    public string? LastDate { get; set; }

    /// <summary>
    /// 统计类型
    /// </summary>
    public string? StatType { get; set; }

    /// <summary>
    /// 项目类型
    /// </summary>
    public string? ItemType { get; set; }

    /// <summary>
    /// 检验总数
    /// </summary>
    public string? TestSum { get; set; }
}
