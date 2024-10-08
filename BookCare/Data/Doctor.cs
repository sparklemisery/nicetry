﻿using System;
using System.Collections.Generic;

namespace BookCare.Data;

public partial class Doctor
{
    public string Did { get; set; } = null!;

    public string? Name { get; set; }

    public string? DoctorImg { get; set; }

    public string? Phone { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public virtual ICollection<DetailDoctor> DetailDoctors { get; set; } = new List<DetailDoctor>();

    public virtual Account DidNavigation { get; set; } = null!;

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<HealthRecord> HealthRecords { get; set; } = new List<HealthRecord>();

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual ICollection<Option> Options { get; set; } = new List<Option>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual ICollection<Specialty> Specialties { get; set; } = new List<Specialty>();
}
