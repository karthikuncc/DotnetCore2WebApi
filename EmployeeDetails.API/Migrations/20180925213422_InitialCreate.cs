using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeDetails.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Basesalary = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    C401k = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    Medical = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    Vision = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    Dental = table.Column<decimal>(type: "decimal(9, 2)", nullable: false),
                    TakeHome = table.Column<decimal>(type: "decimal(9, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
