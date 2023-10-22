using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrDoctor
{
    public string DocId { get; set; } = null!;

    public string? DocName { get; set; }

    public string? DocDepartment { get; set; }

    public string? DocHotKey { get; set; }
}
