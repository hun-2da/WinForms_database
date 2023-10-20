using System;
using System.Collections.Generic;

namespace WinForms_database.testDB;

public partial class FriendsLog
{
    public string Phonenumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public string? Content { get; set; }

    public bool Relationship { get; set; }
}
