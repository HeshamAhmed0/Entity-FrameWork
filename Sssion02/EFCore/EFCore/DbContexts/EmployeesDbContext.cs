using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            modelBuilder.Entity<Employee>().HasKey(E => E.Id);

            modelBuilder.Entity<Employee>()
                        .Property<string>("EmployeeName");

            modelBuilder.Entity<Employee>()
                        .Property(E => E.Name)
                        .HasColumnType("varchar")
                        .HasColumnName("EmpName")
                        .HasMaxLength(50);

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
