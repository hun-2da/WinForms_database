// Scaffold-DbContext "server=localhost;database=univDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir univDB -f
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using WinForms_database.univDB;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;

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
            studentbox_repaint();
        }
        /**student_listbox를 다시 그려주기위한 메소드*/
        public void studentbox_repaint(string filterName = "")
        {
            student_listBox.DisplayMember = "Name";
            student_listBox.Items.Clear();

            using (var db = new UnivDbContext())
            {
                var list = db.Students
                    .Where(p => p.Name.Contains(filterName))
                    .ToList();

                foreach (var student in list)
                {
                    student_listBox.Items.Add(student);
                }
            }
        }
        public void subjectbox_repaint()
        {
            subject_listBox.DisplayMember = "name";
            subject_listBox.Items.Clear();

            var item = student_listBox.SelectedItem as Student;
            using (var db = new UnivDbContext())
            {
                var list = db.Subjects
                    .Include(p => p.Classes)
                    .Where(p => p.Classes.Any(c => c.StudentId == item.Id))
                    .ToList();

                foreach (var subject in list)
                {
                    subject_listBox.Items.Add(subject);
                }
            }
        }

        private void a_button_Click(object sender, EventArgs e)
        {
            var item = student_listBox.SelectedItem as Student;
            if (item != null)
            {
                SJ_Form form = new SJ_Form(item);
                if (DialogResult.OK == form.ShowDialog())
                {
                    try
                    {
                        using (UnivDbContext context = new UnivDbContext())
                        {
                            context.Classes.Add(form.classData);
                            context.SaveChanges();
                            subjectbox_repaint();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("오류발생" + ex.Message);
                    }
                }
            }
        }

        private void student_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = student_listBox.SelectedItem as Student;


            if (item != null)
            {
                subject_listBox.DisplayMember = "Name";
                subject_listBox.Items.Clear();

                using (var db = new UnivDbContext())
                {
                    /*클래스에서 학생의 subject 찾음*/
                    var list = db.Classes
                        .Include(p => p.Student)
                        .Include(p => p.Subject)
                        .Where(p => p.StudentId == item.Id)
                        .ToList();
                    foreach (var item2 in list)
                        subject_listBox.Items.Add(item2.Subject);

                    /*db.Students.Add(form.scoreData);
                    db.SaveChanges();*/
                }

            }
        }
        private void u_button_Click(object sender, EventArgs e)
        {
            var student_selected = student_listBox.SelectedItem as Student;

            var subject_selected = subject_listBox.SelectedItem as Subject;
            if (subject_selected != null)
            {
                SJ_Form form = new SJ_Form(student_selected);
                if (DialogResult.OK == form.ShowDialog())
                {
                    try
                    {
                        using (UnivDbContext context = new UnivDbContext())
                        {
                            var item =
                                  context.Classes.First(p => p.StudentId == student_selected.Id && p.SubjectId == subject_selected.Id);

                            context.Classes.Remove(item);
                            context.SaveChanges();

                            //var newItem = new Class();
                            item.StudentId = form.classData.StudentId;
                            item.SubjectId = form.classData.SubjectId;
                            item.Joined = form.classData.Joined;
                            item.MidScore = form.classData.MidScore;
                            item.FinalScore = form.classData.FinalScore;
                            item.Grade = form.classData.Grade;

                            context.Classes.Add(item);
                            

                            context.SaveChanges();
                            subjectbox_repaint();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("오류발생" + ex.Message);
                    }
                }
            }

        }

        private void d_button_Click(object sender, EventArgs e)
        {
            var studentselected = student_listBox.SelectedItem as Student;
            var subjectselected = subject_listBox.SelectedItem as Subject;

            if (studentselected != null)
            {
                if (DialogResult.Yes == MessageBox.Show("정말 지울랍니까?",
                    "삭제", MessageBoxButtons.YesNo))
                {
                    using (UnivDbContext context = new UnivDbContext())
                    {
                        var item =
                            context.Classes.First(p => p.StudentId == studentselected.Id && p.SubjectId == subjectselected.Id);

                        context.Classes.Remove(item);

                        context.SaveChanges();
                    }

                    subjectbox_repaint();
                }
            }

        }
    }
}