// Scaffold-DbContext "server=localhost;database=seatDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir seatDB -f
using WinForms_database.seatDB;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            int count = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    count++;

                    Button button = new Button();
                    button.Tag = false;                                 //버튼의 상태를 나타냄. (스위치 같은 역할?)
                    button.Name = count.ToString();                     //버튼 id
                    button.Location = new Point(10 + 110 * (i - 1),     
                            10 + 110 * (j - 1));
                    button.Size = new Size(100, 100);                   // 사이즈 +10 * i번째 -1 위치 지정
                    button.Text = count.ToString();                     // 버튼 text


                    button.Click += (s, e) =>  //버튼 콜백메소드 s는 object
                    {
                        //if (button.Text.Contains("�����"))
                        if ((bool)button.Tag)
                        {
                            button.Text = button.Name;
                            ToggleSeat(int.Parse(button.Name), false);
                        }
                        else
                        {
                            button.Text = button.Name + "\n�����";
                            ToggleSeat(int.Parse(button.Name), true);
                        }
                    };

                    buttons.Add(button);
                    this.Controls.Add(button);
                }


            }
        }

        void ToggleSeat(int id, bool used)
        {
            using (var db = new SeatDbContext())
            {
                db.Seats.First(p => p.Id == id).Used = used;
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(this.Controls.Count);

            using (var db = new SeatDbContext())
            {
                foreach (var seat in db.Seats)
                {
                    System.Diagnostics.Debug.WriteLine(seat.Id + " " + seat.Used);

                    if (seat.Used)
                    {
                        var button = buttons.First(p => p.Name == seat.Id.ToString());
                        button.Tag = seat.Used;
                        button.Text += "\n�����";
                    }


                }
            }
        }
    }
}