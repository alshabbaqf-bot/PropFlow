using System;
using System.Collections.Generic;

namespace LeaseBridge.API.Models;

public partial class PriorityType
{
    public int PriorityId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();
}
