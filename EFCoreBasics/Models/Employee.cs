using System.ComponentModel.DataAnnotations;

namespace EFCoreBasics.Models
{
    public class Employee
    {
        //[Key]
        public int EmployeeId { get; set; }  //Primary key
        //[Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Salary { get; set; }

        //One-to-one relationship with EmployeeDetails 
        public EmployeeDetails EmployeeDetails { get; set; }  //Reference navigation to dependent entity - EmployeeDetails 

        //One-to-many relationship with Manager
        public int ManagerId { get; set; }  //Foreign key property
        public Manager Manager { get; set; }   //Navigation property to represent the manager

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }  //Collection navigation property
    }
}