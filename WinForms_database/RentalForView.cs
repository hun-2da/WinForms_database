using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_database
{
    internal class RentalForView
    {
        
        public int RentalId { get; set; }
        [DisplayName("자동차모델")]
        public string CarModel { get; set; }

        [DisplayName("색상")]
        public string CarColor { get; set; }
        public string MakerName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
