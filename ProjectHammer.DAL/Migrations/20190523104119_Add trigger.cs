using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectHammer.DAL.Migrations
{
    public partial class Addtrigger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 1,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 2,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 3,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 4,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 5,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 6,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 7,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 8,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 9,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 41, 18, 971, DateTimeKind.Local).AddTicks(8184));

            var trigger = @"CREATE TRIGGER lastModify
                            ON dbo.Employee
                            AFTER UPDATE
                            AS BEGIN
                            UPDATE dbo.Employee
                            SET LastModifyDate = GETDATE()
                            FROM INSERTED i
                            WHERE i.EmployeeNo = Employee.EmployeeNo
                            END";


            migrationBuilder.Sql(trigger);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 1,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 2,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 3,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 4,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 5,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 6,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 7,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 8,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeNo",
                keyValue: 9,
                column: "LastModifyDate",
                value: new DateTime(2019, 5, 23, 12, 38, 53, 79, DateTimeKind.Local).AddTicks(3989));
        }
    }
}
