using System;
using System.Collections.Generic;

namespace WinForms_database.fanDB;

public partial class 아이돌
{
    public string 이름 { get; set; } = null!;

    public string 한자이름 { get; set; } = null!;

    public string? 그룹명 { get; set; }

    public string? 소속사 { get; set; }

    public string? 분야 { get; set; }

    public DateTime 데뷔연도 { get; set; }

    public string? 팬네임 { get; set; }

    public string 혈액형 { get; set; } = null!;

    public bool 그룹 { get; set; }
}
