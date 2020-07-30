using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public DateTime DatePublished { get; set; }

        public int UserId { get; set; }
        public DateTime TimeCreated { get; set; }


    }

    public class Author
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Comment
    {
        public int Body { get; set; }
        public string UserName { get; set; }
        public DateTime TimeCreated { get; set; }

    }
}
