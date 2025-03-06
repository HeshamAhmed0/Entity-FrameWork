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
            optionsBuilder.UseSqlServer("Server = .; Database = Employee ;Trusted_Connection =true");
        }
        public DbSet<Employees> Employee { get; set; }
    }
}
