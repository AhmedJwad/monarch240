using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrPatientType
{
    public string PatId { get; set; } = null!;

    /// <summary>
    /// 样本种类名
    /// </summary>
    public string? PatName { get; set; }

    /// <summary>
    /// 助记符
    /// </summary>
    public string? PatHotKey { get; set; }
}
