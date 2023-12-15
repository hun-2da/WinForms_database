﻿using System;
using System.Collections.Generic;

namespace WinForms_database.hospitalDB;

public partial class Doctor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public virtual ICollection<DoctorPatient> DoctorPatients { get; set; } = new List<DoctorPatient>();
}
