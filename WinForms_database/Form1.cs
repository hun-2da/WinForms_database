// Scaffold-DbContext "server=localhost;database=orderDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir orderDB -f
using Microsoft.EntityFrameworkCore;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Format += ListBox1_Format;
            listBox2.Format += ListBox2_Format;
        }

        private void ListBox2_Format(object? sender, ListControlConvertEventArgs e)
        {
            var item = e.ListItem as POrderDetailForView;

            if (item != null)
            {
                e.Value = string.Format("{0} {1}��",
                    item.ProductName, item.Qty);
            }
        }

        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
        {
            var item = e.ListItem as POrderForView;

            if (item != null)
            {
                e.Value = string.Format("{0} {1}"
                    , item.MemberName,
                    item.Created);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }// 주문을 하기위한 버튼

        public void RefreshData()
        {
            listBox1.Items.Clear();

            using (var db = new orderDB.OrderDbContext())
            {

                var q = from p3 in db.Porders
                                    .Include(p => p.Member)
                                    .Include(p => p.PorderDetails)
                        select new POrderForView()
                        {
                            MemberName = p3.Member.Name,
                            Created = p3.Created,
                            POrderId = p3.Id,
                            Details = (from p1 in p3.PorderDetails
                                       join p2 in db.Products
                                       on p1.ProductId equals p2.Id

                                       // Details에는 PorderDetails 와 Products 테이블의 정보가 필요함을 알 수 있음.

                                       select new POrderDetailForView()
                                       {
                                           ProductId = p1.ProductId,
                                           ProductName = p2.Name,
                                           Price = p2.Price,
                                           Qty = p1.Qty
                                       }).ToList()
                        };

                foreach (var item in q)
                    listBox1.Items.Add(item);

                /*foreach (var order in
                    db.Porders
                    .Include(p => p.Member)
                    .Include(p => p.PorderDetails)
                    )   
                    // 해당 형태의 경우 순회를 하며 모든 데이터를 가져온 후 POrderForView의 View모델로 필요한 데이터만 선별하여 객체화
                {
                    

                    listBox1.Items.Add(new POrderForView()
                    {
                        MemberName = order.Member.Name,
                        Created = order.Created,
                        POrderId = order.Id,
                        Details = (from p1 in order.PorderDetails
                                   join p2 in db.Products
                                   on p1.ProductId equals p2.Id

                                   // id가 같은 요소들을 합병하여 POrderDetailForView객체 형태로.

                                   select new POrderDetailForView()
                                   {
                                       ProductId = p1.ProductId,
                                       ProductName = p2.Name,
                                       Qty = p1.Qty
                                   }).ToList()
                    });
                }*/

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as POrderForView;

            int sum = 0;
            if (selected != null)
            {
                listBox2.Items.Clear();

                foreach (var item in selected.Details)
                {
                    listBox2.Items.Add(item);
                    sum += (item.Price * item.Qty); //가격 * 개수를 sum에 합
                }
            }
            label4.Text = string.Format("{0} 원", sum);  //label text를 변경시켜주는 코드
        }
    }
}