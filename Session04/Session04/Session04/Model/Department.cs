using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Model
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
       
        public ICollection<Employee> Employees { get; set; }

    }
}
