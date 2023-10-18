// Scaffold-DbContext "server=localhost;database=todoDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir todoDB -f

using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using WinForms_database.todoDB;
using WinForms_database.univDB;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;

namespace WinForms_database
{

    public partial class Form1 : Form
    {
        public 일정 classData = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listbox_repaint();
        }
        public void listbox_repaint()
        {
            listbox_1.DisplayMember = "날짜";
            listBox_2.DisplayMember = "날짜";
            listbox_1.Items.Clear();
            listBox_2.Items.Clear();

            using (var db = new TodoDbContext())
            {
                var check_list = db.일정s
                    // .Where(p => p.완료여부 == true)
                    .ToList();

                /* var false_list = db.일정s
                     .Where(p => p.완료여부 == false)
                     .ToList();*/

                foreach (var 일정 in check_list)
                {
                    if (일정.완료여부 == true)
                        listbox_1.Items.Add(일정);
                    else
                        listBox_2.Items.Add(일정);
                }
                /* foreach (var 일정 in false_list)
                 {
                     listBox_2.Items.Add(일정);
                 }*/
            }
            /*
                한번 쿼리해서 쪼개기
             */

        }
        int selectedIndex = 0;
        private void listbox_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var content = listbox_1.SelectedItem as 일정;
            select_change(content);
        }

        private void listBox_2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var content = listBox_2.SelectedItem as 일정;
            select_change(content);

        }
        public void select_change(일정 content)
        {
            using (var db = new TodoDbContext())
            {
                var content_item = db.일정s.First(p => p.날짜 == content.날짜);
                content_box.Text = content_item.할일내용;
                dateTimePicker1.Value = content_item.날짜;
                checkbox.Checked = content_item.완료여부;
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            try
            {
                using (var db = new TodoDbContext())
                {

                    db.일정s.Add(new 일정()
                    {
                        날짜 = dateTimePicker1.Value,
                        할일내용 = content_box.Text,
                        완료여부 = checkbox.Checked,

                    });

                    db.SaveChanges();


                }
                listbox_repaint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류발생" + ex.Message);
            }


        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            using (var db = new TodoDbContext())
            {
                var item = db.일정s
                    .First(p => p.날짜 == dateTimePicker1.Value);

                item.할일내용 = content_box.Text;
                item.완료여부 = checkbox.Checked;

                db.SaveChanges();
            }
            listbox_repaint();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            using (var db = new TodoDbContext())
            {
                var item = db.일정s
                    .First(p => p.날짜 == dateTimePicker1.Value);

                db.일정s.Remove(item);
                db.SaveChanges();
            }

            listbox_repaint();
        }
    }
}