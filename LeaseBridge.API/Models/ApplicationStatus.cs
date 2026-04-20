using System;
using System.Collections.Generic;

namespace LeaseBridge.API.Models;

public partial class ApplicationStatus
{
    public int StatusId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
