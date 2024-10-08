﻿using System;
using System.Collections.Generic;

namespace BookCare.Data;

public partial class Patient
{
    public string Pid { get; set; } = null!;

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Dob { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<HealthRecord> HealthRecords { get; set; } = new List<HealthRecord>();

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Account PidNavigation { get; set; } = null!;
}
