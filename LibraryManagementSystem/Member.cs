using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime MembershipDate { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public List<Book> ReservedBooks { get; set; }
        public List<Book> BorrowwedHistory { get; }
    
    }
}
