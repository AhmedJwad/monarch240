using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrProfileName
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public int? Typeid { get; set; }
}
