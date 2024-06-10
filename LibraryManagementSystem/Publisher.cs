using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }
        public string PublishCount { get; set; }
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }       
   
    }
}
