// Scaffold-DbContext "server=localhost;database=hospitalDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir hospitalDB -f
using WinForms_database.hospitalDB;

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
            listBox1.DisplayMember = "name";
            listBox2.DisplayMember = "name";
            listBox3.DisplayMember = "name";
            listBox4.DisplayMember = "name";
            listBox1.Items.Clear();
            listBox3.Items.Clear();

            using (HospitalDbContext db = new HospitalDbContext())
            {
                listBox1.Items.AddRange(db.Doctors.ToArray());
                listBox3.Items.AddRange(db.Patients.ToArray());
                // 모든 Doctors 요소들을 Arrray형태로 add(AddRange는 한번에 여러개의 요소를 컬렉션에 추가할수 있게끔 해줌)
            }
        }

        void LoadDoctors()
        {
            var selected = listBox1.SelectedItem as Doctor;

            if (selected != null)
            {
                listBox2.Items.Clear();

                using (HospitalDbContext db = new HospitalDbContext())
                {
                    foreach (var item in db.DoctorPatients
                        .Where(p => p.DoctorId == selected.Id)      
                        .Select(p => p.Patient).ToList())       
                        // DoctorPatients테이블에서 선택한 id와 같은 id를 가진 행을 Patient객체로 변환
                        // foegeign key이기 때문에 가능
                    {
                        listBox2.Items.Add(item);
                    }
                }
            }
        }

        void LoadPatients()
        {
            var selected = listBox3.SelectedItem as Patient;

            if (selected != null)
            {
                listBox4.Items.Clear();

                using (HospitalDbContext db = new HospitalDbContext())
                {
                    foreach (var item in db.DoctorPatients
                        .Where(p => p.PatientId == selected.Id)
                        .Select(p => p.Doctor).ToList())
                    // DoctorPatients테이블에서 선택한 id와 같은 id를 가진 행을 Doctor객체로 변환
                    // foegeign key이기 때문에 가능
                    {
                        listBox4.Items.Add(item);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoctors();

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedDoctor = listBox1.SelectedItem as Doctor;
            var selectedPatient = listBox2.SelectedItem as Patient;

            if (selectedDoctor != null && selectedPatient != null)
            {
                using (HospitalDbContext db = new HospitalDbContext())
                {
                    var removeOne = db.DoctorPatients.Where(p => p.PatientId == selectedPatient.Id
                                          && p.DoctorId == selectedDoctor.Id).FirstOrDefault();

                    // DoctorPatients 테이블에 존재하는 PatientId와 같은 id값이 선택되어 있으면서
                    //  DoctorId와 같은 id값이 선택되어있는 첫번째 행을 선택

                    // 즉 의사와 환자를 제거하는 것이아닌 담당되어 있는 항목(DoctorPatients)을 remove


                    if (removeOne != null)
                    {
                        db.Remove(removeOne);   // 해당행을 삭제
                    }

                    db.SaveChanges();
                }
                
                LoadDoctors();
                LoadPatients();
            }

        }
    }
}