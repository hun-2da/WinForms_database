// Scaffold-DbContext "server=localhost;database=scoreDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir scoreDB -f
using WinForms_database.scoreDB;

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
            RefreshData();
        }

        void RefreshData()
        {
            using (var db = new ScoreDbContext())
            {
                StudentCountLabel.Text = db.Scores.Count().ToString();

                /*
                int total = 0;
                foreach(var score in db.Scores)
                {
                    total += score.Kor;
                }

                KorScoreLabel.Text = total.ToString();
                */

                KorScoreLabel.Text = db.Scores.Average(p => p.Kor).ToString();
                // 컬렉션의 평균 값을 계산하는 데 사용


                BestKorStudentLabel.Text = db.Scores
                        .OrderByDescending(p => p.Kor)
                        // OrderByDescending는 특정 기준에 따라 내림차순으로 정렬 오름차순의 경우 그냥 OrderBy로 사용
                        .First().Name;



                BestScoreStudentLabel.Text = db.Scores
                        .OrderByDescending(p => p.Kor + p.Eng + p.Math) // 전체 합의 평균을 구하는 코드.
                        .First().Name;
            }
        }

        private void AddScoreButton_Click(object sender, EventArgs e)
        {
            using (var db = new ScoreDbContext())
            {
                db.Scores.Add(new Score()
                {
                    Id = new System.Random().Next(),
                    Name = textBox1.Text,
                    Kor = int.Parse(textBox2.Text),
                    Eng = int.Parse(textBox3.Text),
                    Math = int.Parse(textBox4.Text),
                });
                db.SaveChanges();
            }

            RefreshData();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}