using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublicationYear { get; set; }
        public string Type { get; set; }
        public int PageCount { get; set; }
        public int CopyCount { get; set; }
        public List<Author> Authors { get; set; }

        public List<Member> BorrowwedHistory { get; }

        public List<Staff> DeliveryStaff { get; }

        public List<Publisher> Publishers { get; set; }
    }
}
