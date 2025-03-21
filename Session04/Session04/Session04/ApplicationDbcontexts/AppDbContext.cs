using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session04.Model;

namespace Session04.ApplicationDbcontexts
{
    internal class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Session04 ; Trusted_Connection = true ;TrustServerCertificate = true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOne(E => E.Department)
                                           .WithMany(D => D.Employees)
                                           .HasForeignKey(C => C.Id);
                                          
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
