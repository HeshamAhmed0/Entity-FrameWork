using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.Model
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
