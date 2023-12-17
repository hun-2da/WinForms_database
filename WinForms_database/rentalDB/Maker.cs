using System;
using System.Collections.Generic;

namespace WinForms_database.rentalDB;

public partial class Maker
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Country { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
