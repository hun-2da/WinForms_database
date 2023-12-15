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
            foreach (var item in listBox3.Items)//listbox3의 아이템 확인
            {
                if ((item as PorderDetail).ProductId == selectedProduct.Id)
                // PorderDetail에 해당 product의 id와 같은 id 의 상품이 존재할때
                {
                    (item as PorderDetail).Qty += qty;  // 수 추가
                    updateFlag = true;                  // update를 했으므로 insert를 못하게끔
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
                    list.Add(item as PorderDetail);                 // 모든 listbox3의 item들을 porderDetail객체로 list에 삽입

                db.Porders.Add(new Porder()                         //  주문자를 추가
                {
                    Created = DateTime.Now,
                    MemberId = selectedMember.Id,
                    PorderDetails = list
                });
                // 주문자는 선택된 해당 id의 사람이며 모든 해당상품의 porderDetails list를 추가.

                db.SaveChanges();
            }
        }
    }
}
