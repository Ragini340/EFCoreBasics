namespace EFCoreBasics.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }  //Primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //One-to-many relationship with Employee
        public ICollection<Employee> Employees { get; set; }  //Collection navigation property to represent the employees managed
                                                             //by the manager  
    }
}