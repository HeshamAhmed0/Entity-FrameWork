using EFCore.DbContexts;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeesDbContext employeesDbContext = new EmployeesDbContext();


            #region Insert
            //Employee Emp01 = new Employee()
            //{
            //    Id = 0,
            //    Age = 50,
            //    Name = "Hesham",
            //    Salary = 5000,

            //};
            //Console.WriteLine(employeesDbContext.Entry<Employee>(Emp01).State); //Detaged
            //employeesDbContext.Employees.Add(Emp01); //
            //employeesDbContext.Set<Employee>().Add(Emp01);
            //Console.WriteLine(employeesDbContext.Entry<Employee>(Emp01).State); //Added
            //employeesDbContext.Add(Emp01);
            //Console.WriteLine(employeesDbContext.Entry<Employee>(Emp01).State);
            //Console.WriteLine(Emp01.Id);

            //employeesDbContext.SaveChanges();
            //Console.WriteLine(employeesDbContext.Entry<Employee>(Emp01).State); //UnChangeed 
            #endregion

            #region Select     
            //employeesDbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //var emp01=employeesDbContext.Employees.FirstOrDefault(E => E.Id==1);
            //Console.WriteLine($"{emp01.Id}  {emp01.Name}  {emp01.Salary}");
            //Console.WriteLine(employeesDbContext.Entry<Employee>(emp01).State); //Detaged
            //emp01.Name = "Omar";
            //employeesDbContext.SaveChanges();
            //Console.WriteLine(employeesDbContext.Employees.First().ToString());
            //Console.WriteLine(employeesDbContext.Employees.Where(E =>E.Id==1).FirstOrDefault());
            //Console.WriteLine(employeesDbContext.Employees.FirstOrDefault(E => E.Id == 1)); //in this Case Will Return Top(1)
            //Console.WriteLine(employeesDbContext.Employees.SingleOrDefault(E => E.Id == 1)); //in this Case Will Return Top(2)
            #endregion

        }
    }
}
