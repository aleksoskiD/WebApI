using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApIHomework.Models
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public int YearOfPublish { get; set; }

        public string AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}