using System;
using System.Collections.Generic;

namespace LeaseBridge.API.Models;

public partial class LeaseStatus
{
    public int StatusId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lease> Leases { get; set; } = new List<Lease>();
}
