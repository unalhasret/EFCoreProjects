using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Models
{
    internal class BookDbContext : DbContext
    {
        public BookDbContext()
        {

        }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1ET94B3\\SQLEXPRESS;Database=BookDB;Trusted_Connection=True;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, AuthorName = "Frank Herbert" },
                new Author { AuthorId = 2, AuthorName = "Bram Stoker" },
                new Author { AuthorId = 3, AuthorName = "Mary Shelley" },
                new Author { AuthorId = 4, AuthorName = "Ursula K. Le Guin" }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Dune", AuthorId = 1 },
                new Book { BookId = 2, Title = "Dracula", AuthorId = 2 },
                new Book { BookId = 3, Title = "Frankenstein", AuthorId = 3 },
                new Book { BookId = 4, Title = "Mülksüzler", AuthorId = 4 },
                new Book { BookId = 5, Title = "Dune Mesihi", AuthorId = 1 },
                new Book { BookId = 6, Title = "Dune Çocukları", AuthorId = 1 },
                new Book { BookId = 7, Title = "Dune Tanrı İmparatoru", AuthorId = 1 },
                new Book { BookId = 8, Title = "Son İnsan", AuthorId = 3 },
                new Book { BookId = 9, Title = "Karanlığın Sol Eli", AuthorId = 4 }
                );
        }
    }
}
