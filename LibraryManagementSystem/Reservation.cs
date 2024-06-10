using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public List<Book> ReservedBooks { get; set; }
        public List<Member> Members { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Status { get; set; }
    }
}
