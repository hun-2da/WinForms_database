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
            listBox1.DisplayMember = "name";
            listBox2.DisplayMember = "name";


            using (var db = new OrderDbContext())
            {
                foreach (var select_item in db.Members.ToList())
                {
                    listBox1.Items.Add(select_item);
                }
                foreach (var selecte_item_2 in db.Products.ToList())
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
            var member_name = listBox1.SelectedItem as Member;
            var product_name = listBox2.SelectedItem as Product;
            int gty = int.Parse(textBox1.Text);

            using (var db = new OrderDbContext())
            {
               /* db.Porderdetails.Add(
                    
                    );  */ 
            }
        }
    }
}
