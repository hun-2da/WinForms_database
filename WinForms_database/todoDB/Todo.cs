using System;
using System.Collections.Generic;

namespace WinForms_database.todoDB;

public partial class Todo
{
    public DateTime 날짜 { get; set; }

    public string 수행자 { get; set; } = null!;

    public virtual ICollection<TodoContent> TodoContents { get; set; } = new List<TodoContent>();
}
