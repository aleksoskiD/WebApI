using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApIHomework.Models
{
    public class Author
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}