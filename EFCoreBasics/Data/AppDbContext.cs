using EFCoreBasics.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasics.Data
{
    //In Code First Approach at first we will write code then using commands we will create database tables.
    //DBContext class
    public class AppDBContext : DbContext
    {
        //In below DbSet is a generic class and can be used to query and save instances of Employee
        public DbSet<Employee> Employees { get; set; } //Employee Table
        //In below DbSet is a generic class and can be used to query and save instances of Manager
        public DbSet<Manager> Managers { get; set; }  //Manager Table
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public string ConnectionString { get; }

        public AppDBContext()
        {
            //Initial Catalog = DB Name, Integrated Security = Means we will make use of windows authentication
            ConnectionString = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=EmployeeMngt_EFCorePractice;Integrated Security=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set up DB connection
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure primary key
            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);

            modelBuilder.Entity<Employee>()
                .Property(b => b.FirstName)
                .IsRequired();

            //Many-to-Many relationship
            modelBuilder.Entity<EmployeeProject>()
                .HasKey(ep => new {ep.EmployeeId, ep.ProjectId});

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(ep => ep.EmployeeId);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(ep => ep.ProjectId);
        }
        /*Migration Commands: Add-Migrartion InitialCreate
         * Update-Database
         */
    }
}