using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DbContexts
{
    internal class EmployeeDbContext :DbContext
    {
        public EmployeeDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Employee_Details ; Trusted_Connection = true ; TrustServerCertificate = true ;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
