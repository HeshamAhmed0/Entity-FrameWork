using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    }
}
