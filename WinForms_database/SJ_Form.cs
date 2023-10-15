using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_database.univDB;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_database
{
    public partial class SJ_Form : Form
    {
        public Class classData = null;
        WinForms_database.univDB.Student student = null;

        public SJ_Form(WinForms_database.univDB.Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void SJ_Form_Load(object sender, EventArgs e)
        {
            alllistbox.DisplayMember = "Name";
            alllistbox.Items.Clear();

            using (var db = new UnivDbContext())
            {
                var list = db.Subjects
                    .ToList();

                foreach (var student in list)
                {
                    alllistbox.Items.Add(student);
                }
            }
        }
        private void y_button_Click(object sender, EventArgs e)
        {
           // Form1 form = new Form1();
            var selected = alllistbox.SelectedItem as Subject;
            if (selected != null)
            {
                classData = new Class()
                {
                    StudentId = student.Id,
                    SubjectId = selected.Id,
                    Joined = DateTime.Now,
                    MidScore = null,
                    FinalScore = null,
                    Grade = null
                    /*Student = student,
                    Subject = selected*/
                };

                this.DialogResult = DialogResult.OK;
            }else this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void n_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
