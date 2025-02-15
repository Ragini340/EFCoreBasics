﻿namespace EFCoreBasics.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int EmployeeId { get; set; }  //Foreign key
        public Employee Employee { get; set; }  //Reference navigation property
    }
}