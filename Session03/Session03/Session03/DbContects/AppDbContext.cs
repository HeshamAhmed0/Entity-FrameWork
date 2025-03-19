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
            modelBuilder.Entity<StudentCourse>()
                        .HasKey(FK => new { FK.StdId, FK.CrsId });

            modelBuilder.Entity<StudentCourse>()
                        .HasOne(SC => SC.Student)
                        .WithMany(S => S.StudentCourses)
                        .HasForeignKey(SC => SC.StdId);


            modelBuilder.Entity<StudentCourse>()
                        .HasOne(SC=>SC.Course)
                        .WithMany(C=>C.StudentCourses)
                        .HasForeignKey(SC => SC.CrsId);

            //modelBuilder.Entity<Student>()
            //            .HasMany(SC => SC.StudentCourses)
            //            .WithOne(S => S.Student)
            //            .HasForeignKey(S => S.StdId);
            //modelBuilder.Entity<Course>()
            //            .HasMany<StudentCourse>(SC => SC.StudentCourses)
            //            .WithOne(C => C.Course)
            //            .HasForeignKey(S => S.CrsId);

            #region Data Seeding Using Migration 
            //modelBuilder.Entity<Student>()
            //                .HasData(
            //        new Student { Id = 50, Age = 20, Name = "Khaled" }
            //        ); 
            #endregion
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get;set; }
    }
}
