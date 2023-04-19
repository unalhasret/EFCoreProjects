using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
    }
}
