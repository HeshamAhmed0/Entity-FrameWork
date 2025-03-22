using Session04.ApplicationDbcontexts;
using Session04.Model;

namespace Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext appDbContext = new AppDbContext();


            #region Insert

            //Department Dept01 = new Department()
            //{
            //    //DeptId = 1,
            //    DeptName= "Test",
            //};
            //appDbContext.Add(Dept01);
            //appDbContext.SaveChanges();


            //Employee Employee01 = new Employee()
            //{
            //    Name = "hassan",
            //    Age = 20,
            //    DepartmentId = 5,
            //    Id = 5,
            //};
            //appDbContext.Add(Employee01);
            //appDbContext.SaveChanges();
            #endregion

            #region Join Operator

            #region Query Syntax
            //var Result = from E in appDbContext.Employees
            //             join D in appDbContext.Departments
            //             on E.DepartmentId equals D.DeptId
            //             select new
            //             { 
            //                EmployeeId = E.Id,
            //                EmployeeNAme= E.Name,
            //                EmployeeAge= E.Age, 
            //                DepartmentId= D.DeptId,
            //                DepartmentName= D.DeptName

            //             };
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //} 
            #endregion

            #region Fluent Syntax 
            //var Result = appDbContext.Employees.Join(appDbContext.Departments
            //                                        , E => E.DepartmentId
            //                                        , D => D.DeptId
            //                                        ,(E ,D) =>new
            //                                        {
            //                                            EmployeeId = E.Id,
            //                                            EmployeeNAme = E.Name,
            //                                            EmployeeAge = E.Age,
            //                                            DepartmentId = D.DeptId,
            //                                            DepartmentName = D.DeptName

            //                                        });
            //foreach (var Employee in Result)
            //{ Console.WriteLine(Employee); }
            #endregion

            #endregion

            #region View
            //var Result = from item in appDbContext.employeeDepartmentViews
            //             select item;
            //foreach (var item in Result) { Console.WriteLine(item); } 
            #endregion

            #region MaxBy , MinBy
            //var Emp=  appDbContext.Employees.MaxBy(E => E.Id);

            //var Emp = appDbContext.Employees.OrderByDescending(E => E.Id).FirstOrDefault();
            //Console.WriteLine(Emp.Name); 
            #endregion



        }
    }
}
