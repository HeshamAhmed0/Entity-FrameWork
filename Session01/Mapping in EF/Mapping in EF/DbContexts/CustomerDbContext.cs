using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapping_in_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Mapping_in_EF.DbContexts
{
    internal class CustomerDbContext :DbContext
    {
        public CustomerDbContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EmployeeDb ;Trusted_Connection =true; TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                        .HasKey(E => E.EmpName);

            modelBuilder.Entity<Employees>()
                       // .Property("Name")  if name not found will throw exception
                       .Property<string>("name");

            modelBuilder.Entity<Employees>()
                       .Property(E => E.EmpName)
                       .HasColumnName("EmployeeName")
                       .HasColumnType("varchar")
                       .HasMaxLength(50)
                       .IsRequired(false); //Allow Null
        }
        public DbSet<Employees> Employee { get; set; }
    }
}
