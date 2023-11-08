using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinForms_database.orderDB;

namespace WinForms_database
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private void AddForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox1.DisplayMember = "name";
            listBox2.DisplayMember = "name";


            using (var db = new OrderDbContext())
            {
                foreach (var select_item in db.Members.ToList()) //모든 member
                {
                    listBox1.Items.Add(select_item);
                }
                foreach (var selecte_item_2 in db.Products.ToList()) // 모든 product
                {
                    listBox2.Items.Add(selecte_item_2);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new OrderDbContext())
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedMember = listBox1.SelectedItem as Member;
            var selectedProduct = listBox2.SelectedItem as Product;
            var qty = int.Parse(textBox1.Text);

            bool updateFlag = false;
            foreach (var item in listBox3.Items)
            {
                //var s_item = item as Porderdetail; 
                if ((item as Porderdetail).ProductId == selectedProduct.Id) 
                    // item 은 object타입이기 때문에 바로 사용하지 못한다.
                {
                    (item as Porderdetail).Qty += qty;
                    updateFlag = true;
                    break;
                }
            }

            if (updateFlag)
            {

            }
            else
            {
                listBox3.Items.Add(new Porderdetail()
                {
                    ProductId = selectedProduct.Id,
                    Qty = qty
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedMember = listBox1.SelectedItem as Member;

            using (OrderDbContext db = new OrderDbContext())
            {
                List<Porderdetail> list = new List<Porderdetail>();
                foreach (var item in listBox3.Items)
                    list.Add(item as Porderdetail);

                db.Porders.Add(new Porder()
                {
                    Created = DateTime.Now,
                    MemberId = selectedMember.Id,
                    Porderdetails = list
                });

                db.SaveChanges();
            }
        }
    }
}
