// Scaffold-DbContext "server=localhost;database=univDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir univDB -f
using Microsoft.EntityFrameworkCore;
using WinForms_database.univDB;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Format += ListBox1_Format;
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
            // 현재 인덱스 순으로 리스트 박스를 포매팅
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new UnivDbContext())
            {
                /*
                var q = (from p in db.Classes
                        join p2 in db.Students
                        on p.StudentId equals p2.Id
                        join p3 in db.Subjects
                        on p.SubjectId equals p3.Id      
                
                //이런 형태로 사용한 이유는 3개의 테이블을 사용하기 위함으로 보인다.

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
                //. Include 메소드를 사용하여 관련된 Student와 Subject 테이블의 데이터도 함께 가져와 사용
                // 외래키가 있기때문에 접근이 가능하다. (Include를 통해 가져올 수 있지만 데이터 불일치가 발생가능)

                foreach (var item in q)
                {
                    listBox1.Items.Add(new ClassForView()
                    {
                        StudentName = item.Student.Name,
                        StudentId = item.StudentId,
                        SubjectName = item.Subject.Name,
                        SubjectId = item.SubjectId,
                    });
                }//통으만든 q를 전부 ClassForView로 객체화해서 사용
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