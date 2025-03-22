using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Center.ApplicationDbContexts;
using Center.Models;

namespace Center.Transaction
{
    internal static class InsertIntoConstructor
    {
        public static void InserConstructor()
        {
            AppDbContext appDbContext = new AppDbContext();


            Console.WriteLine("**********Hellow New Constructor Page**********");
            
            Console.Write("Enter Constructor Name : ");
            string Name = Console.ReadLine();

            Console.Write("Enter Constructor Salary : ");
            decimal Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Constructor PhoneNumber : ");
            string PhoneNumber = Console.ReadLine();

            Console.Write("Enter Constructor DepartmentId : ");
            int DepartmentId = int.Parse(Console.ReadLine());


            Constructor NewConstructor = new Constructor()
            {
                ConstructorName =Name,
                PhoneNumber=PhoneNumber,
                Salary=Salary,
                DeptId=DepartmentId,
            };
            appDbContext.Add(NewConstructor);
            appDbContext.SaveChanges();


        }
    }
}
