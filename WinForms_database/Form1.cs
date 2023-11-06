// Scaffold-DbContext "server=localhost;database=testDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir testDB -f
using Org.BouncyCastle.Tls;
using System.Windows.Forms;
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

            //listBox1.Format += ListBox1_Format; // 리스트 박스의 형식을 ListBox1_Format이라는 이름의 함수로 추가하는 문장
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.DisplayMember = "name";
            listBox2.DisplayMember = "name";
            listBox3.DisplayMember = "name";
            listBox4.DisplayMember = "name";



            using (var db = new TestDbContext())
            {
                /*var dpctor_item = db.Doctors.ToList();

                foreach (var item in dpctor_item)
                {
                    listBox1.Items.Add(item);
                    //addRange(db.Dcotors.ToArray())
                }

                var patient_item = db.Patients.ToList();
                foreach (var item3 in patient_item)
                {
                    listBox1.Items.Add(item3);
                    //
                }*/

                listBox1.Items.AddRange(db.Doctors.ToArray());
                listBox3.Items.AddRange(db.Patients.ToArray());
                // C#에서 컬렉션에 새 항목을 추가하는 메소드
            }

        }

        /**리스트박스의 형식을 지정해주는 함수*/
        /*        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
                //sender은 listbox, e는  리스트 박스에 표시될 항목에 대한 정보를 제공
                {
                    // value는 리스트박스에 표시될 항목 값
                    e.Value = (e.ListItem as todoDB.Todo)   //e.ListItem은 작성한 데이터베이스의 todo테이블 속성값을 가진다.
                        .날짜.ToString("yyyy-MM-dd")
                        + " " +
                        (e.ListItem as todoDB.Todo).수행자;
                    // ToString() 메서드를 사용하여 날짜와 수행자를 문자열로 변환
                }*/

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            //listBox2.DisplayMember = "name";
            var selected = listBox1.SelectedItem as Doctor;

            if (selected != null)
            {
                using (TestDbContext db = new TestDbContext())
                {
                    /*foreach (var item in db.DoctorPatients    // 작성한 데이터베이스의 item을 해당 테이블의 속성을 가지게끔 
                        .Where(p => p.DoctorId == (selected as testDB.Doctor).Id))
                        listBox2.Items.Add(item);*/
                    foreach (var item in db.DoctorPatients
                            /*db.DoctorPatients*/
                            .Where(p => p.DoctorId == selected.Id)
                            .Select(p => p.Patient).ToList())
                    {
                        listBox2.Items.Add(item);
                    }
                    //include처럼 들고옴 

                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            var selected = listBox3.SelectedItem as Patient;

            if (selected != null)
            {
                using (TestDbContext db = new TestDbContext())
                {
                    /*foreach (var item in db.DoctorPatients    // 작성한 데이터베이스의 item을 해당 테이블의 속성을 가지게끔 
                        .Where(p => p.DoctorId == (selected as testDB.Doctor).Id))
                        listBox2.Items.Add(item);*/
                    foreach (var item in db.DoctorPatients
                            /*db.DoctorPatients*/
                            .Where(p => p.PatientId == selected.Id)
                            .Select(p => p.Doctor).ToList())
                    {
                        listBox4.Items.Add(item);
                    }
                    //include처럼 들고옴 

                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            /*var selected = listBox1.SelectedItem as Doctor;

            using(TestDbContext db = new TestDbContext())
            {
            *//*    var delete_item = db.DoctorPatients
                    .Where(p=>p.DoctorId == selected.Id)*//*

                foreach(var item in db.DoctorPatients
                    .Where(p=>p.DoctorId == selected.Id)
                    .Select(p => p.Patient).ToList())
                {
                    db.Remove(item);
                }
                var delete_item = db.DoctorPatients
                    .Where(p => p.DoctorId == selected.Id).First();

                db.Remove(delete_item);
                db.SaveChanges();
            }*/

            var selected = listBox2.SelectedItem as Patient;
            var selected2 = listBox1.SelectedItem as Doctor;

            if(selected!= null && selected2 != null)
            {
                using (TestDbContext db = new TestDbContext())
                {
                    db.DoctorPatients.Where(p => p.PatientId == selected2.Id)&&()
                }
            }
        }
    }

    /*private void button1_Click(object sender, EventArgs e)
    {
        using (TestDbContext db = new TestDbContext())
        {
            //var date1 = dateTimePicker1.Value;

            var todo1 = db.Doctors
                .FirstOrDefault(p => p.Id == date1);
            // FirstOrDefault는 시퀀스의 첫 번째 요소를 반환하거나, 시퀀스에 요소가 없는 경우 기본값을 반환

            if (todo1 != null)
            {
                todo1.TodoContents.Add(new TodoContent()
                {

                });
            }
            else //기본값을 반환하기위한 부분이다.
            {
                db.Todos.Add(new todoDB.Todo()
                {
                    날짜 = dateTimePicker1.Value,
                    수행자 = textBox1.Text,
                    TodoContents = new List<TodoContent>()  //리스트 박스에 새로운 TodoContent형식의 새 항목 추가
                        {
                            new TodoContent()
                            {
                                할일내용 = textBox2.Text,
                                완료여부 = checkBox1.Checked
                                ? true : false
                            }
                        }
                });
            }

            db.SaveChanges();
        }
        repaint();
    }
    }*/

}