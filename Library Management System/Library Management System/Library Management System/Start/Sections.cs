using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.DbContexts;
using Library_Management_System.Models;
using Microsoft.EntityFrameworkCore;

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
            Console.Write("Enter Department Number : ");
            int DepartmentNumber =int.Parse(Console.ReadLine());
            Book NewBook = new Book()
            {
                BookName = BookName,
                BookSalary = Salary,
                DepartmentId = DepartmentNumber,
            };
            dbContext.Books.Add(NewBook);
            dbContext.SaveChanges();
        }

        public void InsertIntoPerson()
        {
            Console.Write("Enter Person Name : ");
            string Name = Console.ReadLine();
            Console.Clear();
            int BookId=0;
            bool PersonResult=false;
           while (PersonResult==false)
            {
                Console.Write("Enter Book Id : ");
                 BookId = int.Parse(Console.ReadLine());
                foreach (var book in dbContext.Books)
                {
                    if (book.BookNumber == BookId)
                    {
                       PersonResult = true;
                    }
                    else
                    {
                        Console.WriteLine("BookId id not Correct");
                    }
                }
            }

            Person NewPerson = new Person()
            {
                Name = Name,
                DateTime = DateTime.Now,
                BookId = BookId,
            };
            dbContext.Persons.Add(NewPerson);
            dbContext.SaveChanges();

        }
        #endregion

        #region Delete Section 
        public void DeleteFromBooks()
        {

        }
        #endregion

        #region SelectSection
        int Input;
        public void SelectFromBooks()
        {
            Console.WriteLine("Do You Need To Select All Books ");
            Console.Write("1 : Yes  &&  2 : No  ");
             Input = int.Parse(Console.ReadLine());
            if (Input == 1)
            {
                var Result = dbContext.Books.Join(dbContext.Departments,
                                                 B => B.DepartmentId,
                                                 D => D.DepartmentNumber,
                                                 (B, D) => new
                                                 {
                                                     BookId =B.BookNumber,
                                                     BookName =B.BookName,
                                                     BookSalary =B.BookSalary,
                                                     BookDepartment=D.DepartmentName,
                                                 });
                foreach(var  item in Result)
                {
                    Console.WriteLine(item);
                }
            }
            if(Input == 2)
            {
                Console.Write("Enter Name Of Book You Need : ");
                string NameOfBook = Console.ReadLine();
                Console.Clear();
              foreach(var item in  dbContext.Books)
                {
                    if (item.BookName == NameOfBook)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine("This Book Not Founded ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your Input Is Not Correct .");
            }
            
        } 

        public void SelectFromDepartment()
        {
            Console.WriteLine("Do You Need To Select All Department ");
            Console.Write("1 : Yes  &&  2 : No  ");
             Input = int.Parse(Console.ReadLine());
             if(Input == 1)
            {
                foreach(var item in dbContext.Departments)
                {
                    Console.WriteLine(item);
                }
            }
            else if(Input == 2)
            {
                Console.Write("Enter Id For Department You Need : ");
                Input=int.Parse(Console.ReadLine());
                foreach (var item in dbContext.Departments)
                {
                    if (item.DepartmentNumber==Input)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.WriteLine("Id Is Not Correct");
                    }
                }
            }
        }

        public void SelectFromPerson()
        {
            Console.WriteLine("Do You Need To Select All Persons ");
            Console.Write("1 : Yes  &&  2 : No  ");
            Input = int.Parse(Console.ReadLine());
            if(Input == 1)
            {
                var Result03 = dbContext.Persons.Join(dbContext.Books,
                                                     C => C.BookId,
                                                     B => B.BookNumber,
                                                     (C, B) => new
                                                     {
                                                         Id = C.Id,
                                                         Name = C.Name,
                                                         TimeOfBorrowBook =C.DateTime,
                                                         BookName=B.BookName,
                                                     });

                foreach (var item in Result03)
                {
                    Console.WriteLine(item);
                }
                
            }
        }
        #endregion

    }
}
