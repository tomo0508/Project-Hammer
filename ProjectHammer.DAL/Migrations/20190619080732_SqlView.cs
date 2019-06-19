using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectHammer.DAL.Migrations
{
    public partial class SqlView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 1,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 742, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 2,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 3,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 4,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 5,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 6,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 7,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 8,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 9,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 10, 7, 32, 743, DateTimeKind.Local).AddTicks(1801));

            var sqlView = @"CREATE VIEW vwDepartment
                                        AS
                                        SELECT
                                        departmentNo AS departmentNo,
                                        (departmentName + ' ' + departmentLocation) AS departmentDescription
                                        FROM
                                        Department";



            migrationBuilder.Sql(sqlView);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 1,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 2,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 3,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 4,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 5,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 6,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 7,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 8,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 9,
                column: "LastModifyDate",
                value: new DateTime(2019, 6, 19, 9, 52, 42, 521, DateTimeKind.Local).AddTicks(7086));
        }
    }
}
