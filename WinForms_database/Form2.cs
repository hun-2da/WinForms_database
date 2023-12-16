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
    public partial class Form2 : Form
    {
        public todoDB.Todo todoData { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            todoData = new todoDB.Todo()
            {
                Id = dateTimePicker1.Value,
                PersonName = textBox1.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
