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



        }
    }
}
