using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Shelf
    {
        public int ShelfNumber { get; set; }
        public string ShelfName { get; set; }

        public List<Book> Books { get; set; }
    
    }
}
