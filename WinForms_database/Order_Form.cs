using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_database.orderDB;

namespace WinForms_database
{
    public partial class Order_Form : Form
    {
        주문자정보 select = null;
        int IU = 0;
        public Order_Form(주문자정보 select, int iU)
        {
            InitializeComponent();
            this.select = select;

            dateTimePicker1.Value = select.날짜및시간;
            textBox2.Text = select.주문타입.ToString();
            textBox1.Text = select.주문자연락처.ToString();
            comboBox1.Text = select.주문상태;
            IU = iU;
        }
        public Order_Form(int iU)
        {
            InitializeComponent();
            IU = iU;
        }
        public void add_item()
        {
            using(var db = new OrderDbContext())
            {
                db.주문자정보s.Add(new 주문자정보()
                {
                    날짜및시간 = dateTimePicker1.Value,
                    주문타입 = textBox2.Text,
                    주문자연락처 = int.Parse(textBox1.Text),
                    주문상태 = comboBox1.Text
                }) ;
                db.SaveChanges();
            }
        }
        public void upd_item()
        {
            using (var db = new OrderDbContext())
            {
                var item = db.주문자정보s.First(p => p.날짜및시간 == select.날짜및시간);
                item.주문자연락처 = int.Parse(textBox1.Text);
                item.주문타입 = textBox2.Text;
                item.주문상태 = comboBox1.Text;
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
