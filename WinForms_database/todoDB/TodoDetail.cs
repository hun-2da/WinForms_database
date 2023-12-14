using System;
using System.Collections.Generic;

namespace WinForms_database.todoDB;

public partial class TodoDetail
{
    public DateTime Id { get; set; }

    public DateTime TodoId { get; set; }

    public string Title { get; set; } = null!;

    public bool IsDone { get; set; }

    public virtual Todo Todo { get; set; } = null!;
}
