using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        public Employee E { get; set; }  //Total Participate
        [InverseProperty(nameof(Employee.DepartmentD))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
