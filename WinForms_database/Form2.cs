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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBox3.Format += ListBox3_Format;
        }
        private void ListBox3_Format(object? sender, ListControlConvertEventArgs e)
        {
            var item = e.ListItem as POrderDetailForView;

            if (item != null)
            {
                e.Value = string.Format("{0} {1}개",
                    item.ProductName, item.Qty);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox1.DisplayMember = "name";
            listBox2.DisplayMember = "name";

            using (OrderDbContext db = new OrderDbContext())
            {
                foreach (var member in db.Members.ToList())
                {
                    listBox1.Items.Add(member);
                }

                foreach (var product in db.Products.ToList())
                {
                    listBox2.Items.Add(product);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var selectedMember = listBox1.SelectedItem as Member;
            var selectedProduct = listBox2.SelectedItem as Product;
            var qty = int.Parse(textBox1.Text);

            bool updateFlag = false;
            foreach (var item in listBox3.Items)
            {
                if ((item as POrderDetailForView).ProductId == selectedProduct.Id)
                {
                    (item as POrderDetailForView).Qty += qty;
                    updateFlag = true;
                    break;
                }
            }

            if (updateFlag)
            {

            }
            else
            {
                listBox3.Items.Add(new PorderDetail()   // porderDetail을 insert
                {
                    ProductId = selectedProduct.Id,     // 고른 상품 id
                    Qty = qty
                });
            }

            // 아직 데이터베이스에 적용하지 않음. 해당 버튼은 담기 버튼이기 때문
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedMember = listBox1.SelectedItem as Member;   // 물건을 구매시킬 손님 지정

            using (OrderDbContext db = new OrderDbContext())
            {
                List<PorderDetail> list = new List<PorderDetail>();

                foreach (var item in listBox3.Items)
                {
                    list.Add(new PorderDetail()
                    {
                        ProductId = (item as POrderDetailForView).ProductId,
                        Qty = (item as POrderDetailForView).Qty
                    });

                }

                // 주문자는 선택된 해당 id의 사람이며 모든 해당상품의 porderDetails list를 추가.

                db.SaveChanges();
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selected = listBox3.SelectedItem as POrderDetailForView;
            // 이번에는 View모델을 위한 클래스를 외부에 만들었음
            // 해당 item을 POrderDetailForView 객체로, add부분에서도 변경되었음.

            if (selected != null)
                listBox3.Items.Remove(selected);
        }

        private void AllRemoveButton_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear(); 
        }
        //db에는 저장안되어있음으로 list에서만 삭제
    }
}
