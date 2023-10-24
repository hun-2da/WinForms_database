using System;
using System.Collections.Generic;

namespace WinForms_database.orderDB;

public partial class 주문메뉴정보
{
    public DateTime 날짜및시간 { get; set; }

    public string 메뉴명 { get; set; } = null!;

    public int 수량 { get; set; }

    public DateTime 첫번째테이블의날짜및시간 { get; set; }

    public virtual 주문자정보 첫번째테이블의날짜및시간Navigation { get; set; } = null!;
}
