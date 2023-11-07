// Scaffold-DbContext "server=localhost;database=orderDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir orderDB -f
namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();

            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}