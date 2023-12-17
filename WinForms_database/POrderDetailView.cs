using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_database
{
    public class POrderForView
    {
        public int POrderId { get; set; }
        public string MemberName { get; set; }
        public DateTime Created { get; set; }
        public List<POrderDetailForView> Details { get; set; }
    }

    public class POrderDetailForView
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}
