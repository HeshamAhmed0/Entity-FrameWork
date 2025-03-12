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
            optionsBuilder.UseSqlServer("Server = .; Database = Test ; Trusted_Connection = true ;TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
                       //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration()); 
                       //modelBuilder.ApplyConfigurationsFromAssembly(assembly : Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly());


            //Foreign Key will initialize in Table Employee
            //modelBuilder.Entity<Employee>()
            //            .HasOne(E => E.Department)
            //            .WithOne(D => D.E)
            //            .HasForeignKey<Department>(F => F.DeptId);

            // Foreign Key will initialize in Table department
            //modelBuilder.Entity<Department>()
            //            .HasOne(D => D.E)
            //            .WithOne(E => E.Department)
            //            .HasForeignKey<Employee>(f => f.Id);






        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Addres> Addreses { get; set; } ///*NotValid*/

    }
}
