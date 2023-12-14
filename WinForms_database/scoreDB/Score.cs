using System;
using System.Collections.Generic;

namespace WinForms_database.scoreDB;

public partial class Score
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Kor { get; set; }

    public int Math { get; set; }

    public int Eng { get; set; }
}
