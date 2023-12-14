﻿using System;
using System.Collections.Generic;

namespace WinForms_database.carRDB;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
