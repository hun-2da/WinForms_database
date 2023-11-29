// Scaffold-DbContext "server=localhost;database=todoDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir todoDB -f
using System.Windows.Forms;
using WinForms_database.todoDB;

namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Clear();
            listBox1.Format += ListBox1_Format;
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
                foreach (var item in db.Todos.ToList())
                    listBox1.Items.Add(item);
            }
        }

        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
        {
            // e는 목록에 대한 정보제공을 해줌.
            e.Value = (e.ListItem as todoDB.Todo).Id.ToString("yyyy-MM-dd") + " " + (e.ListItem as todoDB.Todo).PersonName;
            // ListItem: 형식화되는 목록 항목을 나타냅니다
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.DisplayMember = "title";
            var selected = listBox1.SelectedItem as todoDB.Todo;

            if (selected != null)
            {
                using (TodoDbContext db = new TodoDbContext())
                {
                    foreach (var item in
                        db.TodoDetails
                        .Where(p => p.TodoId == selected.Id
                            && p.TodoPersonName == selected.PersonName))

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

                if (todo1 != null)
                {
                    /*
                    todo1.TodoDetails.Add(new TodoDetail()
                    {
                        Title = textBox2.Text,
                        IsDone = checkBox1.Checked ? (ulong)1 : 0
                    });
                    */
                    db.SaveChanges();
                }
                else
                {
                    db.Todos.Add(new todoDB.Todo()
                    {
                        Id = dateTimePicker1.Value,
                        PersonName = textBox1.Text,
                        /*
                        TodoDetails = new List<TodoDetail>()
                        {
                            new TodoDetail()
                            {
                                Title = textBox2.Text, 
                                IsDone = checkBox1.Checked 
                                ? (ulong)1 : 0 
                            }   
                        }
                        */
                    });
                }


            }
        }

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
                        MessageBox.Show(ex.Message, "DB������Ʈ ����");
                    }
                }

                DataRefresh();
            }
        }

        private void AddTodoDetailButton_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as todoDB.Todo;

            if (selected != null)
            {
                //textBox2
                //checkBox1

                using (var db = new TodoDbContext())
                {

                    db.TodoDetails.Add(new TodoDetail()
                    {
                        Id = DateTime.Now,
                        TodoId = selected.Id,
                        TodoPersonName = selected.PersonName,
                        Title = textBox1.Text,
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