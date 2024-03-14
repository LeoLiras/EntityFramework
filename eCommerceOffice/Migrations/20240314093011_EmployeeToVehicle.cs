using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerceOffice.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeToVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Vehicles_VehicleId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeeVehicle",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    InitialBondDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVehicle", x => new { x.EmployeeId, x.VehicleId });
                    table.ForeignKey(
                        name: "FK_EmployeeVehicle_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeVehicle_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 1, 1 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9081), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 2, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9109), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 7, 2 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 3, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9111), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 6, 3 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 4, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9112), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "EmployeesSectors",
                keyColumns: new[] { "EmployeeId", "SectorId" },
                keyValues: new object[] { 5, 4 },
                column: "Created",
                value: new DateTimeOffset(new DateTime(2024, 3, 14, 6, 30, 10, 892, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Identification", "Name" },
                values: new object[,]
                {
                    { 1, "ABC123", "Mobi" },
                    { 2, "BCA324", "Argo" },
                    { 3, "ASD342", "Onix" },
                    { 4, "JKL123", "Celta" },
                    { 5, "POJ876", "HB20" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVehicle_VehicleId",
                table: "EmployeeVehicle",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeVehicle");

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "EmployeeId",
                value: null);

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

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleId",
                table: "Vehicles",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Vehicles_VehicleId",
                table: "Vehicles",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }
    }
}
