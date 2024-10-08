using System;
using System.Collections.Generic;

namespace BookCare.Data;

public partial class Service
{
    public string ServiceId { get; set; } = null!;

    public string? ServiceName { get; set; }

    public string? ServiceImg { get; set; }
}
