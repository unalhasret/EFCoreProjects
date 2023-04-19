﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Models
{
    internal class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public virtual ICollection<Book> Books { get;} = new List<Book>();

    }
}
