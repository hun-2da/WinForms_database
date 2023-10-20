// Scaffold-DbContext "server=localhost;database=testDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir testDB -f
using WinForms_database.testDB;

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
            repaint();
        }
        public void repaint()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";

            using (var db = new TestDbContext())
            {
                var list = db.FriendsLogs.ToList();

                if (list != null)
                {
                    foreach (var item in list)
                    {
                        if (item.Relationship == true)
                            listBox1.Items.Add(item);
                        else listBox2.Items.Add(item);
                    }
                }
            }

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            using (var db = new TestDbContext())
            {
                db.FriendsLogs.Add(
                    new FriendsLog()
                    {
                        Birthday = dateTimePicker1.Value,
                        Content = textBox2.Text,
                        Name = textBox1.Text,
                        Phonenumber = textBox3.Text,
                        Relationship = checkBox1.Checked
                    }
                );
                db.SaveChanges();
                repaint();
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            using(var db = new TestDbContext())
            {
                // 데이터 베이스에서 찾을 값 p=>p.phonenumber 과 현재 box3에 저장된 값과 같은 값의 행을 가지고 옴
                var item = db.FriendsLogs.First(p=>p.Phonenumber == textBox3.Text);

                item.Name = textBox1.Text;
                item.Content = textBox2.Text;
               item.Relationship=   checkBox1.Checked;
                item.Birthday = dateTimePicker1.Value;
                item.Relationship = checkBox1.Checked;
                db.SaveChanges();
            }
            
            
            repaint();
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using(var db = new TestDbContext())
            {

                var item = db.FriendsLogs.First(p => p.Phonenumber == textBox3.Text);
                db.FriendsLogs.Remove(item);

                db.SaveChanges() ;
            }
            repaint();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택한 정보를 가지고 input시킬 박스들에 기입 후 수정 삭제 등
            var list_select = listBox1.SelectedItem as FriendsLog;
            selcetItemChange(list_select);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list_select = listBox2.SelectedItem as FriendsLog;
            selcetItemChange(list_select);

        }
        public void selcetItemChange(FriendsLog 친구)
        {
            using (var db = new TestDbContext())
            {
                // 데이터 베이스의 친구 휴대폰 번호와 listbox에서 선택한 친구 정보의 폰 넘버를 대조하여 같은 넘버를 가진 맨 첫번째 멤버 선택
                var item = db.FriendsLogs.First(p => p.Phonenumber == 친구.Phonenumber);
                textBox1.Text = item.Name;
                textBox2.Text = item.Content;
                checkBox1.Checked = item.Relationship;
                dateTimePicker1.Value = item.Birthday;
                textBox3.Text = item.Phonenumber;
            }
        }

    }
}