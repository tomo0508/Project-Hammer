using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectHammer.DAL.Migrations
{
    public partial class AddstoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 1,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 2,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 3,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 4,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 5,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 6,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 7,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 8,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 9,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 51, 3, 212, DateTimeKind.Local).AddTicks(3612));

                var storeProcedure = @"CREATE PROCEDURE spIncreaseSalary
                                     @id int,
                                     @percent float
                                AS
                                BEGIN
                                SET NOCOUNT ON;
                                UPDATE Employee
                                SET Salary = Salary * ((@percent + 100) / 100)
                                WHERE EmployeeNo = @id
                                END";

            migrationBuilder.Sql(storeProcedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 1,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 2,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 3,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 4,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 5,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 6,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 7,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 8,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 9,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 19, 187, DateTimeKind.Local).AddTicks(8704));
        }
    }
}
