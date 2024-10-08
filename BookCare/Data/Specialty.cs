using System;
using System.Collections.Generic;

namespace BookCare.Data;

public partial class Specialty
{
    public string SpecialtyId { get; set; } = null!;

    public string? SpecialtyName { get; set; }

    public string? SpecialtyImg { get; set; }

    public string? ServiceId { get; set; }

    public virtual ICollection<Doctor> Dids { get; set; } = new List<Doctor>();
}
