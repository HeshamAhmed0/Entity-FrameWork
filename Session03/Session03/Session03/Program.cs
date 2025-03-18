using Microsoft.EntityFrameworkCore;
using Session03.DbContects;
using Session03.Models;

namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbContext appDbContext = new AppDbContext();

            #region Manual seed Data
            //List<Student> students = new List<Student>()
            //{
            //    new Student(){Name="hesham",Age=21},
            //    new Student(){Name="hassan",Age=19},
            //}; 

            //appDbContext.Students.AddRange(students);
            //appDbContext.SaveChanges();
            #endregion

            #region EagerLoading




            //var StudentCorse = appDbContext.Students.Include(E => E.StudentCourses).FirstOrDefault(E => E.Id == 4);
            //Console.WriteLine(StudentCorse);


            var Student01 = appDbContext.Set<StudentCourse>().Include(E => E.Student).FirstOrDefault(E => E.StdId == 4);

            Console.WriteLine($"StudentId = {Student01?.StdId}");
            Console.WriteLine(Student01?.CrsId);
            Console.WriteLine(Student01?.Grade);
            Console.WriteLine(Student01?.Student.Name);

            //var StdCource =(from D in appDbContext.Students
            //                    where D.Id==Student01.StdId
            //                    select D).FirstOrDefault();
            //    Console.WriteLine(StdCource.Id);
            //    Console.WriteLine(StdCource.Name);
            //    Console.WriteLine(StdCource.Age);




            #endregion
        }
    }
}
