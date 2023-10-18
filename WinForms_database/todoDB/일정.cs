using System;
using System.Collections.Generic;

namespace WinForms_database.todoDB;

public partial class 일정
{
    public DateTime 날짜 { get; set; }

    public string 할일내용 { get; set; } = null!;

    public bool 완료여부 { get; set; }
}
