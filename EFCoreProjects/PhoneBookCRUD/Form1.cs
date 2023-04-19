using PhoneBookCRUD.Models;

namespace PhoneBookCRUD
{
    public partial class Form1 : Form
    {
        PhoneBookDbContext _context = new PhoneBookDbContext();
        public Form1()
        {
            InitializeComponent();
            DataRefresh();
        }

        public void DataRefresh()
        {
            dataGridView1.DataSource = _context.Contacts.ToList();
        }

        public void TextClear()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _context.Contacts.Add(new Contact { FirstName = txtName.Text, LastName = txtSurname.Text, PhoneNumber = txtPhoneNumber.Text });
            _context.SaveChanges();
            TextClear();
            DataRefresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updatedPhone = _context.Contacts.SingleOrDefault(x => x.Id == (int)dataGridView1.CurrentRow.Cells[0].Value);
            updatedPhone.FirstName = txtName.Text;
            updatedPhone.LastName = txtSurname.Text;
            updatedPhone.PhoneNumber = txtPhoneNumber.Text;
            _context.Contacts.Update(updatedPhone);
            _context.SaveChanges();
            TextClear();
            DataRefresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchResults = _context.Contacts.Where(x => x.FirstName.Contains(txtSearch.Text) || x.LastName.Contains(txtSearch.Text));
            dataGridView1.DataSource = searchResults.ToList();
            txtSearch.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var updatedPhone = _context.Contacts.SingleOrDefault(x => x.Id == (int)dataGridView1.CurrentRow.Cells[0].Value);
            _context.Contacts.Remove(updatedPhone);
            _context.SaveChanges();
            DataRefresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}