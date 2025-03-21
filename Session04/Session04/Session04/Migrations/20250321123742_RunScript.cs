using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session04.Migrations
{
    /// <inheritdoc />
    public partial class RunScript : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create view SelectFromEMployee
with Encryption 
As 
select E.Name EmployeeName ,E.Age EmployeeAge, E.Id EmployeeId ,D.DeptName DepartmentName
from Departments D , Employees E
where D.DeptId=E.DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop  View SelectFromEMployee");
        }
    }
}
