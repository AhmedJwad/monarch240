using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrDepartment
{
    public string DepId { get; set; } = null!;

    public string? DepName { get; set; }

    public string? DepHotKey { get; set; }
}
