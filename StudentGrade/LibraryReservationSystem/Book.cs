using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryReservationSystem
{
    internal class Book
    {
        public string Title {  get; set; }
        public bool IsAvailable {  get; set; }
        public string Reserved { get; set; }

        static List<Book> books = new List<Book>()
        {
            new Book {Title = "Drama", IsAvailable = true},
            new Book {Title = "Adeventure", IsAvailable = true},
            new Book {Title = "Novels", IsAvailable = true},
            new Book {Title = "Life", IsAvailable = true}
        };



    }
}
