using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectHammer.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(maxLength: 20, nullable: true),
                    DepartmentLocation = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentNo);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginUserName = table.Column<string>(maxLength: 20, nullable: false),
                    LoginPassword = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginNo);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeName = table.Column<string>(maxLength: 50, nullable: false),
                    Salary = table.Column<float>(nullable: false),
                    DepartmentNo = table.Column<int>(nullable: false),
                    LastModifyDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeNo);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentNo",
                        column: x => x.DepartmentNo,
                        principalTable: "Department",
                        principalColumn: "DepartmentNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentNo", "DepartmentLocation", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "London", "Development" },
                    { 2, "Zurich", "Development" },
                    { 3, "Osijek", "Development" },
                    { 4, "London", "Sales" },
                    { 5, "Zurich", "Sales" },
                    { 6, "Osijek", "Sales" },
                    { 7, "Basel", "Sales" },
                    { 8, "Lugano", "Sales" }
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "LoginNo", "LoginPassword", "LoginUserName" },
                values: new object[,]
                {
                    { 1, "ItsNotSoft", "Bill" },
                    { 2, "trollsRule", "Jean" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeNo", "DepartmentNo", "EmployeeName", "LastModifyDate", "Salary" },
                values: new object[,]
                {
                    { 7, 1, "Bill Gates", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(5161), 25000f },
                    { 2, 3, "Bernard Katic", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(4739), 50000f },
                    { 8, 3, "Maja Janic", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(5247), 30000f },
                    { 9, 3, "Igor Horvat", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(5329), 35000f },
                    { 1, 4, "Fred Davies", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(4511), 50000f },
                    { 3, 5, "Rich Davies", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(4841), 30000f },
                    { 4, 6, "Eva Dobos", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(4922), 30000f },
                    { 6, 7, "Jean Michele", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(5080), 25000f },
                    { 5, 8, "Mario Hunjadi", new DateTime(2019, 5, 23, 12, 38, 52, 885, DateTimeKind.Local).AddTicks(5004), 25000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentNo",
                table: "Employee",
                column: "DepartmentNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
