using Books.Models;

namespace Books
{
    public partial class Form1 : Form
    {
        BookDbContext _context = new BookDbContext();
        public Form1()
        {
            InitializeComponent();
            AuthorRefresh();
        }
        
        public void AuthorRefresh()
        {
            dgvAuthor.DataSource = _context.Authors.ToList();
        }

        public void BookRefresh()
        {
            var books = _context.Books.Where(x => x.AuthorId == (int)dgvAuthor.CurrentRow.Cells[0].Value);
            dgvBook.DataSource = books.ToList();
        }
        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            _context.Authors.Add(new Author { AuthorName = txtAuthor.Text });
            _context.SaveChanges();
            AuthorRefresh();
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            var deletedAuthor = _context.Authors.Where(x => x.AuthorId == (int)dgvAuthor.CurrentRow.Cells[0].Value);
            var deletedAuthorBooks = _context.Books.Where(x => x.AuthorId == (int)dgvAuthor.CurrentRow.Cells[0].Value);
            _context.Authors.RemoveRange(deletedAuthor);
            _context.Books.RemoveRange(deletedAuthorBooks);
            _context.SaveChanges();
            AuthorRefresh();
            BookRefresh();
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAuthor.Text = dgvAuthor.CurrentRow.Cells[1].Value.ToString();
            BookRefresh();
        }

        private void btnAuthorUpdate_Click(object sender, EventArgs e)
        {
            var updatedAuthor = _context.Authors.SingleOrDefault(x => x.AuthorId == (int)dgvAuthor.CurrentRow.Cells[0].Value);
            updatedAuthor.AuthorName = txtAuthor.Text;
            _context.Authors.Update(updatedAuthor);
            _context.SaveChanges();
            AuthorRefresh();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            var books = new Book { Title = txtBook.Text, AuthorId = (int)dgvAuthor.CurrentRow.Cells[0].Value };
            _context.Books.Add(books);
            _context.SaveChanges();
            BookRefresh();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBook.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            var updatedBook = _context.Books.SingleOrDefault(x => x.BookId == (int)dgvBook.CurrentRow.Cells[0].Value);
            updatedBook.Title = txtBook.Text;
            _context.Books.Update(updatedBook);
            _context.SaveChanges();
            BookRefresh();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            var deletedBook = _context.Books.Where(x => x.BookId == (int)dgvBook.CurrentRow.Cells[0].Value);
            _context.Books.RemoveRange(deletedBook);
            _context.SaveChanges();
            BookRefresh();
        }
    }
}