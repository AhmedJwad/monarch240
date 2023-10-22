using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrProfileItem
{
    public int Id { get; set; }

    public int? ProfileId { get; set; }

    public int? ItemId { get; set; }

    public int? Typeid { get; set; }
}
