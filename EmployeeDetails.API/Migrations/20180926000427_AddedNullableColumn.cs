using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeDetails.API.Migrations
{
    public partial class AddedNullableColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TakeHome",
                table: "Employees",
                type: "decimal(9, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TakeHome",
                table: "Employees",
                type: "decimal(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9, 2)",
                oldNullable: true);
        }
    }
}
