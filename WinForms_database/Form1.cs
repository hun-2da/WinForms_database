// Scaffold-DbContext "server=localhost;database=rentalDB;uid=root;pwd=201104" MySql.EntityFrameworkCore -OutputDir rentalDB -f
using Microsoft.EntityFrameworkCore;
using WinForms_database.rentalDB;

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
            List<RentalForView> list = new List<RentalForView>();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            using (var db = new RentalDbContext())
            {
                foreach (var item in db.Rentals
                                    .Include(p => p.Car)
                                    .Include(p => p.Car.Maker)                     //retal테이블이 Maker에 직접 접근 못하기때문에 타고타고
                                    .Include(p => p.Customer))       // 2개의 테이블을 사용.
                                                                     //하여 ViewModel을 작성.
                {
                    list.Add(new RentalForView()
                    {
                        RentalId = item.Id,
                        CarModel = item.Car.ModelName,
                        CarColor = item.Car.Color,
                        CustomerName = item.Customer.Name,
                        MakerName = item.Car.Maker.Name,
                        RentalDate = item.RentalDate,
                        ReturnDate = item.ReturnDate
                    });
                }

                listBox1.DisplayMember = "ModelName";
                foreach (var item in db.Cars)
                {
                    listBox1.Items.Add(item);
                }
                //Cars형태로 listbox1에 add

                listBox2.DisplayMember = "Name";
                foreach (var item in db.Customers)
                {
                    listBox2.Items.Add(item);
                }
                //Customers형태로 listbox1에 add

            }

            dataGridView1.DataSource = list;
            // DataSource 속성을 설정하기 위해서 사용.
        }

        private void RentalButton_Click(object sender, EventArgs e)
        {
            var selectedCar = listBox1.SelectedItem as Car;         //차량 목록중 택
            var selectedCustomer
                = listBox2.SelectedItem as Customer;                //고객 목록중 택

            if (selectedCar != null && selectedCustomer != null)
            {
                using (var db = new RentalDbContext())
                {
                    db.Rentals.Add(new Rental()
                    {
                        CarId = selectedCar.Id,
                        CustomerId = selectedCustomer.Id,
                        RentalDate = dateTimePicker1.Value,
                        ReturnDate = null
                    });                                             //새로운 rental추가 . ReturnDate는 null
                    db.SaveChanges();
                }

                RefreshData();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            foreach (var item in dataGridView1.SelectedRows)    //SelectedRows란 선택한 행들을 나타냄.
            {
                System.Diagnostics.Debug
                    .WriteLine(
                    ((item as DataGridViewRow).DataBoundItem as RentalForView).RentalId);
            }
        }
    }
}