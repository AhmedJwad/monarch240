using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrRemark
{
    public string Id { get; set; } = null!;

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 助记符
    /// </summary>
    public string? HotKey { get; set; }
}
