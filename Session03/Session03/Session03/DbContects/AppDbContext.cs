using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session03.Models;

namespace Session03.DbContects
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EFSession03 ; Trusted_Connection = true ;TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                        .HasMany(SC => SC.StudentCourses)
                        .WithOne(S => S.Student)
                        .HasForeignKey(S => S.StdId);
            modelBuilder.Entity<Course>()
                        .HasMany<StudentCourse>(SC => SC.StudentCourses)
                        .WithOne(C => C.Course)
                        .HasForeignKey(S => S.CrsId);

            modelBuilder.Entity<Student>()
                        .HasData(
                new Student {Id=50,Age = 20, Name = "Khaled" }
                );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
