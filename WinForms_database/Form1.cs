// Scaffold-DbContext "server=localhost;database=todoDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir todoDB -f
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
            DataRefresh();
        }

        void DataRefresh()
        {
            listBox1.Items.Clear();
            using (TodoDbContext db = new TodoDbContext())
            {
                foreach (var item in db.Todos.ToList())     //ToList를 붙임으로써 한번에 쿼리로 데이터를 가져옴.
                    listBox1.Items.Add(item);
            }
        }


        /**sender은 발생한 widget을 가르킨다. 
         * e는 ListControlConvertEventArgs 객체인데 이 객체는 listbox에서 출력될 문자열을 제어할 수 있는 객체이다.
           ListItem속성과 Value속성이 제공되는데 각각 get과 set으로 보면 될듯? */
        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
        {
            e.Value = (e.ListItem as todoDB.Todo).Id.ToString("yyyy-MM-dd") + " " + (e.ListItem as todoDB.Todo).PersonName;
            //테이블 Todo타입으로 형변환
            //id를 yyyy-,mm-dd형식으로 
            //personName 문자열 같이 출력.
        }

        /**EventArgs는 비어있는 클래스 커스텀해서 사용하는 역할인듯? 
         
         listbox2를 clear하고 title을 가진 */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.DisplayMember = "title";           //listbox2를 title속성값으로 지정
            var selected = listBox1.SelectedItem;

            if (selected != null)
            {
                using (TodoDbContext db = new TodoDbContext())
                {
                    foreach (var item in
                        db.TodoDetails
                        .Where(p => p.TodoId
                        == (selected as todoDB.Todo).Id))
                        // p는 현재 cursor 같은 느낌? cursor.move
                        // TodoTetails에 존재하는 요소중 listbox1이 가진 id값과 같은 cursor부분만 listbox2에 add 

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
                    .FirstOrDefault(p => p.Id == date1);
                // 테이블 Todo에 date1에 해당하는 값들중 가장 첫 값을 저장
                // id값은 primary key이기때문에 이래해도 ㄱㅊ
                // First메소드를 사용하면 exception이 발생하지만 FirstOrDefault를 사용하면 null값 또는 기본값을 return한다.

                if (todo1 != null)
                // 해당 날짜가 존재한다면 해당 날짜로 새로운 할일을 추가 (todoDetails를 insert)
                {
                    todo1.TodoDetails.Add(new TodoDetail()
                    {
                        Title = textBox2.Text,
                        IsDone = checkBox1.Checked ? true : false
                    });
                }
                else  //해당 날짜가 존재하지 않는다면? todo도 추가하고 할일도 추가하고 (todoDetails 와 Todos를 insert)
                {
                    db.Todos.Add(new todoDB.Todo()
                    {
                        Id = dateTimePicker1.Value,
                        PersonName = textBox1.Text,
                        TodoDetails = new List<TodoDetail>()
                        {
                            new TodoDetail()
                            {
                                Title = textBox2.Text,
                                IsDone = checkBox1.Checked
                                ? true : false
                            }
                            /*
                             한번의 쿼리에서 계속해서 추가 가능(todoDetails에 insert가능)
                             
                            new TodoDetail()
                            {
                                ...
                            }
                             */
                        }
                    });
                }
                db.SaveChanges();

            }
        } // 즉 버튼 1의 클릭은 details의 추가에 초점이 맞추어져있다.
        private void AddTodoButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TodoDbContext())
                {
                    try
                    {
                        db.Todos.Add(form.todoData);
                        db.SaveChanges();
                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                    {
                        MessageBox.Show(ex.Message, "DB오류");
                    }
                }

                DataRefresh();
            }
        }

        private void AddTodoDetailButton_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as todoDB.Todo;    //해당 날짜를 선택

            if (selected != null)
            {
                //textBox2
                //checkBox1

                using (var db = new TodoDbContext())
                {

                    db.TodoDetails.Add(new TodoDetail()
                    {
                        Id = DateTime.Now,                          // 해당 TodoDetail의 primarykey이지만 Time까지 추가한 datetime임으로 add 가능.
                        TodoId = selected.Id,                       // 날짜 외래키
                        //TodoPersonName = selected.PersonName,     //열 추가 필요
                        Title = textBox2.Text,
                        IsDone = checkBox1.Checked
                    });

                    /*
                     * ã�ƺ���!
                    selected.TodoDetails.Add(new TodoDetail()
                    {
                        Id = DateTime.Now,                        
                        Title = textBox2.Text,
                        IsDone = checkBox1.Checked
                    });
                    db.Update(selected);
                    */
                    db.SaveChanges();
                }
            }
        }
    }
}