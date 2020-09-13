using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LibraryMid2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Published { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}