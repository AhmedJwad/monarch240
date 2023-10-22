using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrSampleType
{
    public string SamId { get; set; } = null!;

    /// <summary>
    /// 样本种类名
    /// </summary>
    public string? SamName { get; set; }

    /// <summary>
    /// 助记符
    /// </summary>
    public string? SamHotKey { get; set; }
}
