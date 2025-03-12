using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(name: "EmpName", TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        //[ForeignKey(nameof(Department))]     => Data Anotation 
                        //Fluent Api 
        //public int DepartmentDeptId { get; set; }
       /* public Department? Department { get; set; } */  // Partial Participate
        public Addres EmpAddres { get; set; }
        [ForeignKey(nameof(DepartmentD))]
        public int DepartmentId {  get; set; }
        [InverseProperty(nameof(Department.Employees))]
        public Department DepartmentD { get; set; }
    }
}
