using System;
using System.Collections.Generic;

namespace WinForms_database.orderDB;

public partial class 주문자정보
{
    public DateTime 날짜및시간 { get; set; }

    public int 주문자연락처 { get; set; }

    public string 주문타입 { get; set; } = null!;

    public string 주문상태 { get; set; } = null!;

    public virtual ICollection<주문메뉴정보> 주문메뉴정보s { get; set; } = new List<주문메뉴정보>();
}
