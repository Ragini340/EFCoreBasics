namespace EFCoreBasics.Models
{
    //Junction table entity
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }  //Reference navigation property
        public int ProjectId { get; set; }
        public Project Project { get; set; }  //Reference navigation property
    }
}