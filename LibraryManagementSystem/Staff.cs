﻿using System;

namespace LibraryManagementSystem
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public TimeSpan StartShiftDate { get; set; }
        public TimeSpan EndShiftDate { get; set; }
    }
}