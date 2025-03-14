using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
           builder.HasKey(E => E.Id);

          builder.Property<string>("EmployeeName");

         builder.Property(E => E.Name)
                        .HasColumnType("varchar")
                        .HasColumnName("EmpName")
                        .HasMaxLength(50)
                        .IsRequired();
            builder.OwnsOne(E => E.EmpAddres,Addres => Addres.WithOwner());
        }
    }
}
