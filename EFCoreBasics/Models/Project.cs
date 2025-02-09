namespace EFCoreBasics.Models
{
    public class Project
    {
        public int ProjectId { get; set; }  //Primary key
        public string Name { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }  //Collection navigation property 
    }
}