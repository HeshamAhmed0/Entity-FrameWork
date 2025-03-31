using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DbContexts;
using Library_Management_System.Models;

namespace Library_Management_System.Start
{
    internal class Sections
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();

        #region Insert Section 
        public void InsertIntoDepartment()
        {
            Console.Write("Enter DepartmentName : ");
            string DepartmentName = Console.ReadLine();
            Console.Clear();
            Department NewDepartment = new Department()
            {
                DepartmentName = DepartmentName,
            };
            dbContext.Departments.Add(NewDepartment);
            dbContext.SaveChanges();
        }
        public void InsertIntoBooks()
        {
            Console.Write("Enter Book Name : ");
            string BookName = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter Book Salary : ");
            decimal Salary = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Book NewBook = new Book()
            {
                BookName = BookName,
                BookSalary = Salary,
            };
            dbContext.Books.Add(NewBook);
            dbContext.SaveChanges();
        }

        public void InsertIntoPerson()
        {
            Console.Write("Enter Person Name : ");
            string Name = Console.ReadLine();
            Console.Clear();

            Person NewPerson = new Person()
            {
                Name = Name,
                DateTime = DateTime.Now,
            };
            dbContext.Persons.Add(NewPerson);
            dbContext.SaveChanges();
        } 
        #endregion


    }
}
