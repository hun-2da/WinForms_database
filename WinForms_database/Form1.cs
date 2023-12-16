// Scaffold-DbContext "server=localhost;database=univDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir univDB -f
namespace WinForms_database
{
    public partial class Form1 : Form
    {
        List<Contact> contacts;

        public Form1()
        {
            InitializeComponent();
            listBox1.Format += ListBox1_Format;
            listBox2.Format += ListBox2_Format;
            listBox3.Format += ListBox3_Format;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void ListBox3_Format(object? sender, ListControlConvertEventArgs e)
        {
            var callLog = e.ListItem as CallLogForView;
            if (callLog != null)
            {
                e.Value = string.Format("{4} {3} {0} {1} ({2}min)",
                    callLog.When.ToString("MM/dd HH:mm"),
                    callLog.IsIncoming ? "<-" : "->",
                    callLog.Duration, 
                    callLog.PhoneNumber,
                    callLog.FirstName);
            }

        }

        private void ListBox2_Format(object? sender, ListControlConvertEventArgs e)
        {
            var callLog = e.ListItem as CallLog;

            if (callLog != null)
            {
                e.Value = string.Format("{0} {1} ({2}min)",
                    callLog.When.ToString("MM/dd HH:mm"),
                    callLog.Incoming ? "<-" : "->",
                    callLog.Duration);
                // 형식을 지정해줌.
                // 첫번째 파라미터는 날짜와 시간 형식으로
                // 두번째 파라미터는 true 면 <- , false 면 ->
                // 뒤에 min을 붙이고 괄호쳐서 출력
            }
        }

        private void ListBox1_Format(object? sender, ListControlConvertEventArgs e)
        {
            var contact = e.ListItem as Contact;

            if (contact != null)
            {
                e.Value = string.Format("{0} ({1})",
                    contact.FirstName,
                    contact.Phone);
                // 문자열 형식인데 위치를 지정해줌. 1번째 파라미터와 두번째 파라미터를 나열하겠다는 의미를 가진다.
                // contact.FirstName : {0}
                // contact.Phone : {1} 인데 ()를 씌움
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as Contact;

            if (selected != null)
            {
                listBox2.Items.Clear();

                List<CallLog> callLogs = CallLog.SampleData();

                var filtered = callLogs.Where(p => p.Number == selected.Phone);
                // 선택한 사람과 같은 number을 가진 log들을 전부 불러옴

                foreach (var callLog in filtered)
                {
                    listBox2.Items.Add(callLog);
                }
            }
        }

        void DataRefresh(String filterString = "")
        {
            contacts = Contact.SampleData().Where(p => p.FirstName.Contains(filterString) ||
                p.LastName.Contains(filterString) ||
                p.Phone.Contains(filterString) ||
                p.State.Contains(filterString.ToUpper())).ToList();

            //Contains은 해당 문자열이 존재하는지 확인하는 메소드이다.
            // 즉 name또는 phone, state에 해당문자가 포함되어 있는지 확인
            // 메소드의 재사용성을 높이기 위해서 해당 경우가 true일때 해당 열을 가져오는 코드. 현재는 비었음.

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (var contact in contacts)
            {
                listBox1.Items.Add(contact);
            }// 해당 여건에 맞는 모든 list를 가져옴. 지금은 모든 항목을 가져온다.
        }
        /**추가를 위한 버튼*/
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddModifyForms form = new AddModifyForms();
            if (form.ShowDialog() == DialogResult.OK)       // 띄운 dialog가 true인 경우에만.
            {
                listBox1.Items.Add(
                form.ContactData);
            }
        }
        /**업데이트를 위한 버튼*/
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as Contact;
            // 연락처중 한명 선택

            if (selected != null)
            {
                AddModifyForms form = new AddModifyForms();

                form.ContactData = selected;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Remove(selected);
                    listBox1.Items.Add(form.ContactData);
                }
                //삭제후 새로운 값으로 add
                //이렇게 하는 이유는? listbox의 항목 업데이트 하기 위해서
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as Contact;

            if (selected != null)
            {
                if (MessageBox
                    .Show("확인", "정말로 삭제하시겠습니까?", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    listBox1.Items.Remove(selected);// 선택항목을 제거.

                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataRefresh(SearchTextBox.Text);
            //DataRefresh에 filter를 추가한 이유. 해당 경우처럼 검색을 위해서이다.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var callLogs = CallLog.SampleData();
            // 저장된 데이터를 불러옴. db를 불러오는 것과 같은 격.

            var q = from 
                    p in callLogs   //collogs의 정보를 가져옴.
                    join                                        // 특정 조건에 따라 결합.
                    p2 in contacts  //contacts의 정보를 가져옴.
                    on p.Number equals p2.Phone                 // collog의 number와 contacts의 phone이 같을 경우 join
                    //즉 연락처인물과 기록들을 통으로 만듦

                    select new CallLogForView
                    {
                        When = p.When,
                        Duration = p.Duration,
                        IsIncoming = p.Incoming,
                        PhoneNumber = p.Number,
                        FirstName = p2.FirstName
                    };
                    // 통으로 만들어진 결과를 CalLogForView의 객체로 만들어서 사용하고 싶은 정보를 선별하여 편리하게 사용 가능.

            foreach (var item in q)
            {
                listBox3.Items.Add(new CallLogForView()
                {
                    FirstName = item.FirstName,
                    PhoneNumber = item.PhoneNumber,
                    Duration = item.Duration,
                    When = item.When,
                    IsIncoming = item.IsIncoming
                }); //3번째 listbox에 필요한 정보들을 전부 가져오는 코드
            }

        }

    }
    public class CallLogForView
    {
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime When { get; set; }
        public bool IsIncoming { get; set; }
        public int Duration { get; set; }
    }
}