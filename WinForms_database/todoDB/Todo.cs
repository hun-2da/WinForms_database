using System;
using System.Collections.Generic;

namespace WinForms_database.todoDB;

public partial class Todo
{
    public DateTime Id { get; set; }

    public string PersonName { get; set; } = null!;

    public virtual ICollection<TodoDetail> TodoDetails { get; set; } = new List<TodoDetail>();
}
