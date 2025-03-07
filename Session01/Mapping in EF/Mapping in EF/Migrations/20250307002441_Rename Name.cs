using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mapping_in_EF.Migrations
{
    /// <inheritdoc />
    public partial class RenameName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employee",
                newName: "EmpName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "Employee",
                newName: "Name");
        }
    }
}
