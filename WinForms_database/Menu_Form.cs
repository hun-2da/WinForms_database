using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using WinForms_database.orderDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_database
{
    public partial class Menu_Form : Form
    {
        int IU = 0;
        주문자정보 select = null;
        주문메뉴정보 select2 = null;
        public Menu_Form(주문자정보 select, int IU)
        {
            InitializeComponent();
            dateTimePicker1.Value = select.날짜및시간;
            this.select = select;
            this.IU = IU;
        }
        public Menu_Form(주문자정보 select, 주문메뉴정보 select2, int IU)
        {
            InitializeComponent();
            this.select = select;
            this.select2 = select2;
            dateTimePicker1.Value = select.날짜및시간;
            dateTimePicker2.Value = select2.날짜및시간;
            textBox2.Text = select2.메뉴명;
            textBox3.Text = select2.수량.ToString();
            this.IU = IU;
        }

        public void add_item()
        {
            using (var db = new OrderDbContext())
            {
                db.주문메뉴정보s.Add(new 주문메뉴정보()
                {
                    날짜및시간 = dateTimePicker1.Value,
                    첫번째테이블의날짜및시간 = select.날짜및시간,
                    메뉴명 = textBox2.Text,
                    수량 = int.Parse(textBox3.Text)
                });
                db.SaveChanges();
            }
        }
        public void upd_item()
        {
            using (var db = new OrderDbContext())
            {
                var item = db.주문메뉴정보s.First(p => p.날짜및시간 == select2.날짜및시간 && p.첫번째테이블의날짜및시간 == select.날짜및시간);
                item.메뉴명 = textBox3.Text;
                item.수량 = int.Parse(textBox3.Text);
                db.SaveChanges();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (IU == 1) add_item();
            else if (IU == 2) upd_item();

            IU = 0;
            this.Close();
        }
    }
}
