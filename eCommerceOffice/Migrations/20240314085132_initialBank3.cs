using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceOffice.Migrations
{
    /// <inheritdoc />
    public partial class initialBank3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Mari");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "João");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Pedro");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Vanessa");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Thiago");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Vivian");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Renalla");

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 5, 51, 32, 99, DateTimeKind.Unspecified).AddTicks(8331), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 2, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 5, 51, 32, 99, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 7, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 5, 51, 32, 99, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 3, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 5, 51, 32, 99, DateTimeKind.Unspecified).AddTicks(8362), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 6, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 5, 51, 32, 99, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 4, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 5, 51, 32, 99, DateTimeKind.Unspecified).AddTicks(8364), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 5, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 5, 51, 32, 99, DateTimeKind.Unspecified).AddTicks(8365), new TimeSpan(0, -3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 36, 29, 25, DateTimeKind.Unspecified).AddTicks(9334), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 2, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 36, 29, 25, DateTimeKind.Unspecified).AddTicks(9362), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 7, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 36, 29, 25, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 3, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 36, 29, 25, DateTimeKind.Unspecified).AddTicks(9363), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 6, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 36, 29, 25, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 4, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 36, 29, 25, DateTimeKind.Unspecified).AddTicks(9365), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 5, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 36, 29, 25, DateTimeKind.Unspecified).AddTicks(9367), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
