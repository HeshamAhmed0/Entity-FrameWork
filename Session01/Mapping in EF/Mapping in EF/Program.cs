using Mapping_in_EF.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Mapping_in_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Create Object From DbContext

            using CustomerDbContext dbContext = new CustomerDbContext();
            var Emp01=dbContext.Employee.Where(E => E.Id == 1).FirstOrDefault();
            //dbContext.Database.Migrate(); // in this case thw database will generate when the app Run
            //// Some Code 



            //CustomerDbContext dbContext = new CustomerDbContext();
            // try
            // {
            //     //Some code
            // }
            // finally
            // {
            //     //Some code 
            //     // in this this way this code will Run Any Way 
            // } 
            #endregion

            #region Mapping By Convention 

            #endregion
        }
    }
}
