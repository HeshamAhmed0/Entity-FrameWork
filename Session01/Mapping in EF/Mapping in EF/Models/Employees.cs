using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_in_EF.Models
{
    internal class Employees
    {
        // Id Will Generate As Primary Key As => EmployeesId OR Id 
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
    }
}
