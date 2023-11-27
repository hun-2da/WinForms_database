// Scaffold-DbContext "server=localhost;database=univDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir univDB -f
using WinForms_database.univDB;
using Microsoft.EntityFrameworkCore;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Format += ListBox1_Format;//한번만 추가되어야하기때문에 생성자 (formetEvent(콜백메소드))        
        }

        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
        {
            var item = e.ListItem as ClassForView;

            if (item != null)
                e.Value = string.Format("{0}({1}) {2}({3})",
                    item.StudentName,
                    item.StudentId,
                    item.SubjectName,
                    item.SubjectId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new UnivDbContext())
            {
                /*
                var q = (from p in db.Classes

                        join p2 in db.Students
                        on p.StudentId equals p2.Id
                        //db.Students 테이블의 p2라는 별칭으로 데이터를 가져오고, 
                        //p.StudentId가 p2.Id와 같은 경우에만 조인합니다. 
                        //이를 통해 학생 정보와 수업 정보를 연결합니다.
                        
                        join p3 in db.Subjects
                        on p.SubjectId equals p3.Id
                        //이 부분은 db.Subjects 테이블의 p3라는 별칭으로 데이터를 가져오고, 
                        //p.SubjectId가 p3.Id와 같은 경우에만 조인합니다. 
                        //이를 통해 수업 정보와 과목 정보를 연결합니다.
                        
                        
                        select new ClassForView()
                        {
                            StudentName = p2.Name,
                            StudentId = p.StudentId,
                            SubjectName = p3.Name,
                            SubjectId = p.SubjectId
                        }).OrderBy(p => p.StudentId);
                */


                var q = db.Classes
                    .Include(p => p.Student)
                    .Include(p => p.Subject)
                    .ToList();

                foreach (var item in q)
                {
                    listBox1.Items.Add(new ClassForView()
                    {
                        StudentName = item.Student.Name,
                        StudentId = item.StudentId,
                        SubjectName = item.Subject.Name,
                        SubjectId = item.SubjectId,
                    });
                }
            }
        }
    }
    public class ClassForView
    {
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }

    }
}