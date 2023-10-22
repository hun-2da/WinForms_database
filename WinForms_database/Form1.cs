// Scaffold-DbContext "server=localhost;database=fanDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir fanDB -f
using WinForms_database.fanDB;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String radio_button_name = null;
        public 아이돌 select = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            repaint();
        }
        public void repaint()
        {
            listBox1.DisplayMember = "이름";
            listBox2.DisplayMember = "이름";
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            using (var db = new FanDbContext())
            {
                var item = db.아이돌s.ToList();

                foreach (var item2 in item)
                {
                    if (item2.그룹 == true)
                        listBox1.Items.Add(item2);

                    else
                        listBox2.Items.Add(item2);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = listBox1.SelectedItem as 아이돌;
            select_re();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = listBox2.SelectedItem as 아이돌;
            select_re();

        }
        public void select_re()
        {
            using (var db = new FanDbContext())
            {
                var item = db.아이돌s.ToList();
                
                    nametextbox1.Text = select.이름;
                    nametextbox2.Text = select.한자이름;
                    group_textbox.Text = select.그룹명;
                    Entertainment_textbox.Text = select.소속사;
                    checkBox1.Checked = select.그룹;
                    fandomtextbox.Text = select.팬네임;

                    dateTimePicker1.Value = select.데뷔연도;
                    radioselect(select.분야);
                    //comboboxselect(item.혈액형);
                    comboBox1.Text = select.혈액형;
                
            }
            repaint();


        }
        /*public void comboboxselect(string selcet)
        {
            switch (selcet)
            {
                case "A": comboBox1.SelectedIndex = 0; break;
                case "B": comboBox1.SelectedIndex = 1; break;
                case "O": comboBox1.SelectedIndex = 2; break;
                case "AB": comboBox1.SelectedIndex = 3; break;

            }
        }*/
        public void radioselect(String select)
        {

            switch (select)
            {
                case "가수": radioButton1.Checked = true; break;
                case "방송인": radioButton2.Checked = true; break;
                case "유튜버": radioButton3.Checked = true; break;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            radio_button_name = (sender as RadioButton).Text;
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            using (var db = new FanDbContext())
            {
                db.아이돌s.Add(new 아이돌()
                {
                    한자이름 = nametextbox2.Text,
                    이름 = nametextbox1.Text,
                    소속사 = Entertainment_textbox.Text,
                    팬네임 = fandomtextbox.Text,
                    데뷔연도 = dateTimePicker1.Value,
                    분야 = radio_button_name,
                    혈액형 = comboBox1.Text,
                    그룹 = checkBox1.Checked,
                    그룹명 = group_textbox.Text

                });
                db.SaveChanges();
            }

            repaint();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new FanDbContext())
            {
                var item = db.아이돌s.First(p => p.한자이름 == select.한자이름);


                item.이름 = nametextbox1.Text;
                item.소속사 = Entertainment_textbox.Text;
                item.팬네임 = fandomtextbox.Text;
                item.데뷔연도 = dateTimePicker1.Value;
                item.분야 = radio_button_name;
                item.혈액형 = comboBox1.Text;
                item.그룹 = checkBox1.Checked;
                item.그룹명 = group_textbox.Text;
                db.SaveChanges();
            }
            repaint();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(var db = new FanDbContext())
            {
                //var item = db.아이돌s.First(p => p.한자이름 == nametextbox2.Text);
                //if(item != null)
                    db.Remove(select);
                db.SaveChanges();
                
            }
            repaint();
        }
    }
}