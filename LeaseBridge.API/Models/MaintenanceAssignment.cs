using System;
using System.Collections.Generic;

namespace LeaseBridge.API.Models;

public partial class MaintenanceAssignment
{
    public int AssignmentId { get; set; }

    public int RequestId { get; set; }

    public int StaffId { get; set; }

    public DateTime AssignedDate { get; set; }

    public virtual MaintenanceRequest Request { get; set; } = null!;

    public virtual AppUser Staff { get; set; } = null!;
}
