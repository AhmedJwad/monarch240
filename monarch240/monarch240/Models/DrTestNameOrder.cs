using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrTestNameOrder
{
    public int TesCode { get; set; }

    public string? TesName { get; set; }

    public string? TesEname { get; set; }

    public string? TesHotKey { get; set; }

    public short? TesOrder { get; set; }

    public int? TesType { get; set; }
}
