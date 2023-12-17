// Scaffold-DbContext "server=localhost;database=bikeDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir bikeDB -f
using System.ComponentModel;
using WinForms_database.bikeDB;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public List<Bike> bikes = new List<Bike>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();

            using (var db = new BikeDbContext())
            {
                bikes = db.Bikes.ToList();  //bike객체 리스트

                int count = 0;
                foreach (var bike in bikes)
                {
                    Button button = new Button();                                 //버튼 객체생성
                    button.Name = bike.Id.ToString();                           //Name속성을 database의 bike id로지정.
                    button.Text = bike.Id + "호기";                           //Text속성으로 설명
                    button.Tag = bike.Used;                                 //사용중인가? 에대한 설정 true or false 을 대입

                    button.BackColor = bike.Used ? Color.Red : Color.Green;     //만약 db에 Used가 true이면 red _ false이면 green
                    button.Location = new Point(20 + (count++ * 130), 30);      // 위치를 지정. new Poin, x,y좌표
                    button.Size = new Size(120, 120);                           // size

                    button.Click += (s, e) =>                                   // 콜백메소드
                    {
                        if (!bike.Used)//사용중이 아닐때
                        {
                            //update가 아닌 insert (RentalHistory)
                            if (MessageBox.Show(bike.Id + "호기 빌리겠?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                using (var db2 = new BikeDbContext())
                                {
                                    db2.RentalHistories.Add(new RentalHistory()
                                    {
                                        BikeId = bike.Id,                       //빌린 bike id
                                        RentalTime = DateTime.Now               //빌린날
                                    });
                                    db2.Bikes.First(p => p.Id == bike.Id).Used = true;      //해당 bike와 같은 id값을 가진 행의 used를 true로
                                    bike.Used = true;                                       //db에 적용후 디자인에도 적용을 위해
                                    button.BackColor = Color.Red;                           //color 교체
                                    db2.SaveChanges();
                                }
                                RefreshData();
                            }
                        }
                        else
                        {
                            // update
                            if (MessageBox.Show(bike.Id + "호기 반납?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                using (var db2 = new BikeDbContext())
                                {
                                    var item = db2.RentalHistories.Where(p => p.ReturnTime == null && p.BikeId == bike.Id).FirstOrDefault();
                                    //해당 행의 returnTime이 null이고 누른 버튼의 bikeid와 같은 행이 있을때

                                    if (item != null)
                                        item.ReturnTime = DateTime.Now;     //해당 행의 오늘 날짜로 returnTime지정

                                    db2.Bikes.First(p => p.Id == bike.Id).Used = false;     //false로 변경
                                    bike.Used = false;
                                    button.BackColor = Color.Green;
                                    db2.SaveChanges();
                                }
                                RefreshData();
                            }
                        }
                    };

                    this.Controls.Add(button);   // 현재 클래스(폼, 컨트롤 등)의 컨트롤 컬렉션에 새로 생성한 button 객체를 추가
                }
            }
        }

        void RefreshData()
        {
            using (var db = new BikeDbContext())
            {
                dataGridView1.DataSource = db.RentalHistories       //그리드뷰에 add, id값과 빌린시간 반납한 시간을 그림.
                    .Select(p => new RentalDataView()
                    {
                        Id = p.Id,
                        RentalTime = p.RentalTime,
                        ReturnTime = p.ReturnTime
                    }).ToList();

            }
        }

    }

    public class RentalDataView
    {
        [DisplayName("호기")] //사용자 인터페이스(UI)에서 보여지는 이름을 설정하는 데 사용
        public int Id { get; set; }


        [DisplayName("빌린날")]
        public DateTime RentalTime { get; set; }


        [DisplayName("반납한날")]
        public DateTime? ReturnTime { get; set; }
    }
}