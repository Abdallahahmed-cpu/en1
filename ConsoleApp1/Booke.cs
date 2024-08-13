using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Booke
    {
        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public string ISBN { get; set; }
            public int PublicationYear { get; set; }


            public ICollection<BookAuthor> BookAuthors { get; set; }


        }
    }
}
