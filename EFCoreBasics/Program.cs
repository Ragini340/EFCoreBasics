using EFCoreBasics.Data;
using EFCoreBasics.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDBContext())
{
    var employees = context.Employees.Include(e => e.EmployeeDetails).ToList();
    foreach (var emp in employees)
    {
        Console.WriteLine($"Id: {emp.EmployeeDetails.EmployeeId}; Name: {emp.FirstName}; Address: {emp.EmployeeDetails.Address};");
    }

    //Retrieve and display all the employees
    var employees1 = context.Employees.ToList();
    foreach (var emp in employees1)
    {
        Console.WriteLine($"Employee name: {emp.FirstName} - Salary: {emp.Salary}");
    }

    //Insert manager details
    /* var manager = new Manager();
     manager.FirstName = "Mike";
     manager.LastName = "Delfino";

     context.Managers.Add(manager);
     context.SaveChanges();*/

    //Insert employee details
    var employee = new Employee();
    employee.FirstName = "Susan";
    employee.LastName = "Mayar";
    employee.Salary = 1000000;
    employee.ManagerId = 1;
    context.Employees.Add(employee);
    var result = context.SaveChanges();

    //Insert Employee details
    var empDetails = new EmployeeDetails();
    empDetails.Address = "Bangalore";
    empDetails.Email = "test1@gmail.com";
    empDetails.PhoneNumber = "9999999999";
}