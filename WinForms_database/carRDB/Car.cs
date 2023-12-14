using System;
using System.Collections.Generic;

namespace WinForms_database.carRDB;

public partial class Car
{
    public int Id { get; set; }

    public string Modelname { get; set; } = null!;

    public int MakerId { get; set; }

    public string Color { get; set; } = null!;

    public int Rentalprice { get; set; }

    public virtual Maker Maker { get; set; } = null!;

    public virtual ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}
