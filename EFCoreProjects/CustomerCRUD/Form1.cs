using CustomerCRUD.Models;

namespace CustomerCRUD
{
    public partial class Form1 : Form
    {
        NorthwindContext _context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        public void DataRefresh()
        {
            List<Customer> customerList = _context.Customers.ToList();
            dgvCustomers.DataSource = customerList;
        }
        public void TextClear()
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _context.Customers.Add(new Customer() { CustomerId = txtCustomerId.Text, CompanyName = txtCustomerName.Text });
            _context.SaveChanges();
            TextClear();
            DataRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deletedCustomer = _context.Customers.Where(x => x.CustomerId == dgvCustomers.CurrentRow.Cells[0].Value);
            _context.Customers.RemoveRange(deletedCustomer);
            _context.SaveChanges();
            TextClear();
            DataRefresh();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updatedCustomer = _context.Customers.SingleOrDefault(x => x.CustomerId == dgvCustomers.CurrentRow.Cells[0].Value);
            updatedCustomer.CompanyName = txtCustomerName.Text;
            _context.Customers.Update(updatedCustomer);
            _context.SaveChanges();
            TextClear();
            DataRefresh();
            
        }
    }
}