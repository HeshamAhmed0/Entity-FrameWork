using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session03.Migrations
{
    /// <inheritdoc />
    public partial class insertUsingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 50, 20, "Khaled" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
