using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerceOffice.Migrations
{
    /// <inheritdoc />
    public partial class initialBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeesSectors",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesSectors", x => new { x.SectorId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeesSectors_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesSectors_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTeam",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTeam", x => new { x.EmployeesId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_EmployeeTeam_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTeam_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "EmployeeId" },
                values: new object[,]
                {
                    { 1, null },
                    { 2, null },
                    { 3, null },
                    { 4, null },
                    { 5, null },
                    { 6, null },
                    { 7, null }
                });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Logistica" },
                    { 3, "Financeiro" },
                    { 4, "ADM" }
                });

            migrationBuilder.InsertData(
                table: "EmployeesSectors",
                columns: new[] { "EmployeeId", "SectorId", "Created" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2024, 3, 13, 6, 1, 22, 82, DateTimeKind.Unspecified).AddTicks(4313), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 2, 2, new DateTimeOffset(new DateTime(2024, 3, 13, 6, 1, 22, 82, DateTimeKind.Unspecified).AddTicks(4343), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 7, 2, new DateTimeOffset(new DateTime(2024, 3, 13, 6, 1, 22, 82, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 3, 3, new DateTimeOffset(new DateTime(2024, 3, 13, 6, 1, 22, 82, DateTimeKind.Unspecified).AddTicks(4345), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 6, 3, new DateTimeOffset(new DateTime(2024, 3, 13, 6, 1, 22, 82, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 4, 4, new DateTimeOffset(new DateTime(2024, 3, 13, 6, 1, 22, 82, DateTimeKind.Unspecified).AddTicks(4347), new TimeSpan(0, -3, 0, 0, 0)) },
                    { 5, 4, new DateTimeOffset(new DateTime(2024, 3, 13, 6, 1, 22, 82, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, -3, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesSectors_EmployeeId",
                table: "EmployeesSectors",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTeam_TeamsId",
                table: "EmployeeTeam",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleId",
                table: "Vehicles",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesSectors");

            migrationBuilder.DropTable(
                name: "EmployeeTeam");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
