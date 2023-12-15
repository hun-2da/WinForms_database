// Scaffold-DbContext "server=localhost;database=univDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir univDB -f
namespace WinForms_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Format += ListBox1_Format;
            listBox2.Format += ListBox2_Format;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            List<Contact> contacts = Contact.SampleData();

            foreach (var contact in contacts)
            {
                listBox1.Items.Add(contact);
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
    }
}