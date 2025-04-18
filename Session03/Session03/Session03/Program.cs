﻿using Microsoft.EntityFrameworkCore;
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
            //Student Student01 = new Student()
            //{

            //    Name = "Mamdouh",
            //    Age = 20
            //};
            //appDbContext.Students.Add(Student01);
            //appDbContext.SaveChanges();



            ////Course course01 = new Course()
            ////{
            ////    Title = "Database"
            ////};
            ////appDbContext.Courses.Add(course01);
            ////appDbContext.SaveChanges();


            //StudentCourse studentCourse = new StudentCourse()
            //{
            //    StdId = Student01.Id,
            //    CrsId = 50,

            //};
            //appDbContext.StudentCourses.Add(studentCourse);
            //appDbContext.SaveChanges();

            //List<Course> Courses = new List<Course>()
            //{
            //    new Course(){Id=10,Title="Advanced C#"},
            //    new Course(){Id =20,Title="Database"},
            //};

            //appDbContext.Courses.AddRange(Courses);
            //appDbContext.SaveChanges();

            //List<StudentCourse> studentCourses = new List<StudentCourse>()
            //{
            //    new StudentCourse(){StdId=1,CrsId=10,Grade=20},
            //    new StudentCourse(){StdId=2,CrsId=20,Grade=300},
            //};

            //appDbContext.Set<StudentCourse>().AddRange(studentCourses);
            //appDbContext.SaveChanges();
            #endregion

            #region Eager Loading




            //var StudentCorse = appDbContext.Students.Include(E => E.StudentCourses).FirstOrDefault(E => E.Id == 4);
            //Console.WriteLine(StudentCorse);


            //var Student01 = appDbContext.Set<StudentCourse>().Include(E => E.Student).FirstOrDefault(E => E.StdId == 4);

            //Console.WriteLine($"StudentId = {Student01?.StdId}");
            //Console.WriteLine(Student01?.CrsId);
            //Console.WriteLine(Student01?.Grade);
            //Console.WriteLine(Student01?.Student.Name);




            //var StdCource =(from D in appDbContext.Students
            //                    where D.Id==Student01.StdId
            //                    select D).FirstOrDefault();
            //    Console.WriteLine(StdCource.Id);
            //    Console.WriteLine(StdCource.Name);
            //    Console.WriteLine(StdCource.Age);




            #endregion

            #region Explicit Loading
            //var StudentCorse = appDbContext.Set<StudentCourse>().FirstOrDefault(E => E.StdId == 4);
            //Console.WriteLine($"StudentId = {StudentCorse?.StdId}");
            //Console.WriteLine($"CourseId = {StudentCorse?.CrsId}");
            //Console.WriteLine($"Grade = {StudentCorse?.Grade}");
            ////appDbContext.Entry(StudentCorse).Reference(EF => EF.Student).Load();   //  One RelationShip
            //  if(StudentCorse is not null)
            //  {
            //    appDbContext.Entry(StudentCorse).Reference(E => E.Student).Load();
            //  }

            //Console.WriteLine($"StudentName = {StudentCorse?.Student?.Name}");
            #endregion

            #region Lazy Loading
            var Result =
                from D in appDbContext.Courses
                select D.Id;
          foreach(var D in appDbContext.Courses)
            {
                Console.WriteLine(D.Id);
                Console.WriteLine(D.Title);
            }
            #endregion

            #region Join Category
            //var Result = appDbContext.Courses.Join(appDbContext.Set<StudentCourse>()
            //                                              , C => C.Id
            //                                              , S => S.CrsId
            //                                              , (C, SC) => new
            //                                              {
            //                                                  CourseId = C.Id,
            //                                                  CourseName = C.Title,
            //                                                  StudentId = SC.StdId,
            //                                                  StudentGrade = SC.Grade,
            //                                              });

            //var result = appDbContext.Courses.Join(appDbContext.StudentCourses, C => C.Id, SC => SC.CrsId,
            //                                  (C, SC) => new
            //                                  {
            //                                     CourseId = C.Id,
            //                                     CourseTitle =C.Title,
            //                                     StudentId =SC.StdId,
            //                                     StudentGrade=SC.Grade,
            //                                  });
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Group Join 
            //var Result = appDbContext.Courses.GroupJoin(appDbContext.StudentCourses, C => C.Id,SC=>SC.CrsId,(C,SC) => new
            //{
            //    Courses=C,
            //    SC
            //});
            //foreach(var item in Result)
            //{
            //    Console.WriteLine($"CourseId = {item.Courses.Id} , CourseName = {item.Courses.Title}");
            //    foreach (var SC in item.SC)
            //    {
            //        Console.WriteLine(SC.StdId);
            //    }
            //}


            //var Result = appDbContext.Courses.GroupJoin(appDbContext.StudentCourses,
            //                                           C => C.Id,
            //                                           SC => SC.CrsId,
            //                                           (C, SC) => new
            //                                           {
            //                                               C.Id,
            //                                               C.Title,
            //                                               SC

            //                                           }).SelectMany(S => S.SC, (R, E) => new
            //                                           {
            //                                               R.Id,
            //                                               R.Title,
            //                                               E.CrsId,
            //                                               E.StdId,
            //                                               E.Grade
            //                                           });
            //foreach (var result in Result)
            //{
            //    Console.WriteLine($"StudentId = {result.StdId} , CourseId = {result.CrsId} , Grade = {result.Grade}");
            //}

            #endregion
        }
    }
}
