// Scaffold-DbContext "server=localhost;database=todoDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir todoDB -f
using Org.BouncyCastle.Tls;
using System.Windows.Forms;
using WinForms_database.todoDB;

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

            listBox1.Format += ListBox1_Format; // 리스트 박스의 형식을 ListBox1_Format이라는 이름의 함수로 추가하는 문장
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.DisplayMember = "날짜";
            listBox2.DisplayMember = "현재시간";

            using (var db = new TodoDbContext())
            {
                var date_item = db.Todos.ToList();

                foreach (var item in date_item)
                {
                    listBox1.Items.Add(item);
                }
            }

        }

        /**리스트박스의 형식을 지정해주는 함수*/
        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
        //sender은 listbox, e는  리스트 박스에 표시될 항목에 대한 정보를 제공
        {
            // value는 리스트박스에 표시될 항목 값
            e.Value = (e.ListItem as todoDB.Todo)   //e.ListItem은 작성한 데이터베이스의 todo테이블 속성값을 가진다.
                .날짜.ToString("yyyy-MM-dd")
                + " " +
                (e.ListItem as todoDB.Todo).수행자;
            // ToString() 메서드를 사용하여 날짜와 수행자를 문자열로 변환
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.DisplayMember = "할일내용";
            var selected = listBox1.SelectedItem;

            if (selected != null)
            {
                using (TodoDbContext db = new TodoDbContext())
                {
                    foreach (var item in db.TodoContents    // 작성한 데이터베이스의 item을 해당 테이블의 속성을 가지게끔 
                        .Where(p => p.Todo날짜 == (selected as todoDB.Todo).날짜))
                        listBox2.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TodoDbContext db = new TodoDbContext())
            {
                var date1 = dateTimePicker1.Value;

                var todo1 = db.Todos
                    .FirstOrDefault(p => p.날짜 == date1);
                // FirstOrDefault는 시퀀스의 첫 번째 요소를 반환하거나, 시퀀스에 요소가 없는 경우 기본값을 반환

                if (todo1 != null)
                {
                    todo1.TodoContents.Add(new TodoContent()
                    {
                        할일내용 = textBox2.Text,
                        완료여부 = checkBox1.Checked ? true : false
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
    }
}