﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_database
{
    internal class CallLog
    {
        public string Number { get; set; }
        public int Duration { get; set; }
        public bool Incoming { get; set; }
        public DateTime When { get; set; }

        public static List<CallLog> SampleData()
        {
            return new List<CallLog>()
        {
            new CallLog() { Number = "885 983 8858",
                Duration = 2,
                Incoming = true,
                When = DateTime.Parse("7-Aug-2006 8:12")},
            new CallLog() { Number = "165 737 1656", Duration = 15, Incoming = true, When = DateTime.Parse("7 - Aug - 2006 9:23")},
            new CallLog() { Number = "364 202 3644", Duration = 1, Incoming = false, When = DateTime.Parse("7 - Aug - 2006 10:5")},
            new CallLog() { Number = "603 303 6030", Duration = 2, Incoming = false, When = DateTime.Parse("7 - Aug - 2006 10:35")},
            new CallLog() { Number = "546 607 5462", Duration = 4, Incoming = true, When = DateTime.Parse("7 - Aug - 2006 11:15")},
            new CallLog() { Number = "885 983 8858", Duration = 15, Incoming = false, When = DateTime.Parse("7 - Aug - 2006 13:12")},
            new CallLog() { Number = "885 983 8858", Duration = 3, Incoming = true, When = DateTime.Parse("7 - Aug - 2006 13:47")},
            new CallLog() { Number = "546 607 5462", Duration = 1, Incoming = false, When = DateTime.Parse("7 - Aug - 2006 20:34")},
            new CallLog() { Number = "546 607 5462", Duration = 3, Incoming = false, When = DateTime.Parse("8 - Aug - 2006 10:10")},
            new CallLog() { Number = "603 303 6030", Duration = 23, Incoming = false, When = DateTime.Parse("8 - Aug - 2006 10:40") },
            new CallLog() { Number = "848 553 8487", Duration = 3, Incoming = false, When = DateTime.Parse("8-Aug-2006 14:0")},
            new CallLog() { Number = "848 553 8487", Duration = 7, Incoming = true, When = DateTime.Parse("8 - Aug - 2006 14:37")},
            new CallLog() { Number = "278 918 2789", Duration = 6, Incoming = true, When = DateTime.Parse("8 - Aug - 2006 15:23") },
            new CallLog() { Number = "364 202 3644", Duration = 20, Incoming = true, When = DateTime.Parse("8 - Aug - 2006 17:12") }
        };
        }
    }
}
