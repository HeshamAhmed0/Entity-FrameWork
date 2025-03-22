using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Center.ApplicationDbContexts;
using Center.Models;

namespace Center.Transaction
{
    internal static  class InsertIntoDepartment
    {
       public static void InsertDepartment()
        {    
            AppDbContext appDbContext=new AppDbContext();

            Console.Write("Enter Department Name : ");
            string DepartmentName = Console.ReadLine();
            Department NewDepartment = new Department()
            {
                DepartmentName = DepartmentName
            };
            appDbContext.Add(NewDepartment);
                appDbContext.SaveChanges();
        }
    }
}
