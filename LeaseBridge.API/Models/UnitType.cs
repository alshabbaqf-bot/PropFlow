using System;
using System.Collections.Generic;

namespace LeaseBridge.API.Models;

public partial class UnitType
{
    public int TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Unit> Units { get; set; } = new List<Unit>();
}
