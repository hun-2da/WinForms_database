using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_database
{
    public partial class AddModifyForms : Form
    {
        public Contact ContactData;

        public AddModifyForms()
        {
            InitializeComponent();
        }
        
        
        //form이 load되면 자동으로 값을 넣어줌.
        //add버튼의 경우 전부 null이지만 update버튼의 경우 contactData객체의 값을 지정해주고
        //remove -> add 하기때문에 update로 사용
        private void AddModifyForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = ContactData.FirstName;
            textBox2.Text = ContactData.LastName;
            textBox3.Text = ContactData.Phone;
            textBox4.Text = ContactData.Email;
            textBox5.Text = ContactData.DateOfBirth.ToString();
            textBox6.Text = ContactData.State;
        }
        
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.ContactData = new Contact()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Phone = textBox3.Text,
                Email = textBox4.Text,
                DateOfBirth = DateTime.Parse(textBox5.Text),
                State = textBox6.Text
            };
            this.Close();
        } // 해당 입력상자들의 정보를 Contact객체로 만들어서 전달하게끔.

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
