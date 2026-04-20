using System;
using System.Collections.Generic;

namespace LeaseBridge.API.Models;

public partial class MaintenanceUpdate
{
    public int UpdateId { get; set; }

    public int RequestId { get; set; }

    public int StatusId { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual MaintenanceRequest Request { get; set; } = null!;

    public virtual MaintenanceStatus Status { get; set; } = null!;
}
