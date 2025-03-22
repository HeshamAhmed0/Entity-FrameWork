using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Center.Models;
using Microsoft.EntityFrameworkCore;

namespace Center.ApplicationDbContexts
{
    internal class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = CodeTitans ;Trusted_Connection = true ;TrustServerCertificate = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Constructor>().HasOne(E => E.Department)
                                              .WithMany(D => D.Constructor)
                                              .HasForeignKey(D => D.DeptId);

            modelBuilder.Entity<Student>().HasOne(C => C.Constructor)
                                          .WithMany(S => S.Students)
                                          .HasForeignKey(C => C.ConstructorId);

            
        }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
