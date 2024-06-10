using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public  class LoanTransaction
    {
        public int TransactionID { get; set; }
        public DateTime LoanDate  { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Status { get; set; }
        public List <Member> MemberList { get; set; }
        public List <Book> BorrewedBooks { get; set; }
    }
}
