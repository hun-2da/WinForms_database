using System;
using System.Collections.Generic;

namespace WinForms_database.hospitalDB;

public partial class Patient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<DoctorPatient> DoctorPatients { get; set; } = new List<DoctorPatient>();
}
