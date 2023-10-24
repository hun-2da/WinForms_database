// Scaffold-DbContext "server=localhost;database=orderDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir orderDB -f
using WinForms_database.orderDB;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        /**반복문으로 지정해주기위한 array*/
        ListBox[] listbox = new ListBox[3];
        /**list box에서 선택한 주문자 정보 행*/
        주문자정보 select = null;
        주문메뉴정보 select2 = null;


        public Form1()
        {
            InitializeComponent();
            listbox[0] = listBox1;
            listbox[1] = listBox2;
            listbox[2] = listBox3;
            //listbox[3] = listBox4;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repaint();
        }
        public void repaint()
        {
            foreach (var lb in listbox)
            {

                lb.Items.Clear(); lb.DisplayMember = "날짜및시간";
            }

            listBox4.Items.Clear(); listBox4.DisplayMember = "날짜및시간";

            using (var database = new OrderDbContext())
            {

                var item = database.주문자정보s.ToList();
                foreach (var add_list in item)
                {
                    String order_state = add_list.주문상태;
                    switch (order_state)
                    {
                        case "주문확인":
                            listBox1.Items.Add(add_list);
                            break;
                        case "조리중":
                            listBox2.Items.Add(add_list);
                            break;
                        case "조리완료":
                            listBox3.Items.Add(add_list);
                            break;
                    }
                }
                if (select != null)
                {
                    var item2 = database.주문메뉴정보s
                        .Where(p => p.첫번째테이블의날짜및시간 == select.날짜및시간)
                        .ToList();

                    foreach (var add_list4 in item2)
                    {
                        listBox4.Items.Add(add_list4);
                    }
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = listBox1.SelectedItem as 주문자정보;
            repaint();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = listBox2.SelectedItem as 주문자정보;
            repaint();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = listBox3.SelectedItem as 주문자정보;
            repaint();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            select2 = listBox4.SelectedItem as 주문메뉴정보;
        }
        private void add_order_button_Click(object sender, EventArgs e)
        {
            Order_Form form = new Order_Form(1);
            if (DialogResult.OK == form.ShowDialog()) repaint();
        }
        private void update_order_button_Click(object sender, EventArgs e)
        {
            Order_Form form = new Order_Form(select, 2);
            if (DialogResult.OK == form.ShowDialog()) repaint();
        }

        private void delte_order_button_Click(object sender, EventArgs e)
        {
            using (var db = new OrderDbContext())
            {
                db.Remove(select);
                db.SaveChanges();
            }
            repaint();
        }

        private void add_menu_button_Click(object sender, EventArgs e)
        {
            Menu_Form form = new Menu_Form(select, 1);
            if (form.ShowDialog() == DialogResult.OK) repaint();
        }

        private void update_menu_button_Click(object sender, EventArgs e)
        {
            Menu_Form form = new Menu_Form(select, select2, 2);
            if (form.ShowDialog() == DialogResult.OK) repaint();
        }
        private void delete_menu_buttno_Click(object sender, EventArgs e)
        {
            using (var db = new OrderDbContext())
            {
                db.Remove(select2);
                db.SaveChanges();
            }
            repaint();
        }
    }
}