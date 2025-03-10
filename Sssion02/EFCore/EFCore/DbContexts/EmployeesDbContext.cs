using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EFCore.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.DbContexts
{
    internal class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Etsh ; Trusted_Connection = true ;TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
                       //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration()); 
                       modelBuilder.ApplyConfigurationsFromAssembly(assembly : Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly());

        }
       

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
