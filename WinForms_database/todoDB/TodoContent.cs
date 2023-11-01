using System;
using System.Collections.Generic;

namespace WinForms_database.todoDB;

public partial class TodoContent
{
    public DateTime 현재시간 { get; set; }

    public DateTime Todo날짜 { get; set; }

    public string 할일내용 { get; set; } = null!;

    public bool 완료여부 { get; set; }

    public virtual Todo Todo날짜Navigation { get; set; } = null!;
}
