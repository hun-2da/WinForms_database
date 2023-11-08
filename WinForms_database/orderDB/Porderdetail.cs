using System;
using System.Collections.Generic;

namespace WinForms_database.orderDB;

public partial class Porderdetail
{
    public int Id { get; set; }

    public int PorderId { get; set; }

    public int ProductId { get; set; }

    public int Qty { get; set; }

    public virtual Porder Porder { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
