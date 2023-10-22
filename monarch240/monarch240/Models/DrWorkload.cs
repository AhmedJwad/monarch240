using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrWorkload
{
    /// <summary>
    /// 人员姓名或科室名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 工作量
    /// </summary>
    public int? Workload { get; set; }

    /// <summary>
    /// 工作量合计
    /// </summary>
    public string? Total { get; set; }
}
