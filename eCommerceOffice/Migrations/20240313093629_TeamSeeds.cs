using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerceOffice.Migrations
{
    /// <inheritdoc />
    public partial class TeamSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A1" },
                    { 2, "A2" },
                    { 3, "A3" },
                    { 4, "A4" },
                    { 5, "A5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 12, 54, 583, DateTimeKind.Unspecified).AddTicks(5444), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 2, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 12, 54, 583, DateTimeKind.Unspecified).AddTicks(5473), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 7, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 12, 54, 583, DateTimeKind.Unspecified).AddTicks(5481), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 3, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 12, 54, 583, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 6, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 12, 54, 583, DateTimeKind.Unspecified).AddTicks(5480), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 4, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 12, 54, 583, DateTimeKind.Unspecified).AddTicks(5477), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 5, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 13, 6, 12, 54, 583, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
