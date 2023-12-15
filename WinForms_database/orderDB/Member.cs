using System;
using System.Collections.Generic;

namespace WinForms_database.orderDB;

public partial class Member
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public virtual ICollection<Porder> Porders { get; set; } = new List<Porder>();
}
