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
        [DisplayName("자동차 모델")]
        public String CarModel { get; set; }

        [DisplayName("색상")]
        public String CarColor { get; set; }
        public String MakerName { get; set; }
        public String CustomerName { get; set; }

        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        // ? 는 null일 수 있음을 표시.

    }
}
