using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    internal class Book
    {
        public int BookNumber { get; set; }
        public string BookName { get; set; }
        public decimal BookSalary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        

    }
}
