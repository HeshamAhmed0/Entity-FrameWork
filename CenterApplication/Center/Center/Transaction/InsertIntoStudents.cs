using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Center.ApplicationDbContexts;
using Center.Models;

namespace Center.Transaction
{
    internal static class InsertIntoStudents
    {
        public static void InsertStudent()
        {
            AppDbContext appDbContext = new AppDbContext();
            Console.WriteLine("********** Hello In Section Add New Student **********");

            Console.Write("Enter Student Name : ");
            string Name = Console.ReadLine();

            Console.Write("Enter Student Age : ");
            int Age =int.Parse(Console.ReadLine());

            Console.Write("Enter Student PhoneNumber : ");
            string Phone = Console.ReadLine();

            Console.Write("Enter Constructor Id : ");
            int ConstructorId = int.Parse(Console.ReadLine());

            Student NewStudent = new Student()
            {
                StudentName=Name,
                StudentAge=Age,
                PhoneNumber=Phone,
                ConstructorId=ConstructorId
            };
            
            appDbContext.Students.Add(NewStudent);
            appDbContext.SaveChanges();
        }
    }
}
