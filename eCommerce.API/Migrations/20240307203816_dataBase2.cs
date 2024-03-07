using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.API.Migrations
{
    /// <inheritdoc />
    public partial class dataBase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Users_UserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentUser_Users_UsersId",
                table: "DepartmentUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SendAddresses_Users_UserId",
                table: "SendAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "TB_USUARIOS");

            migrationBuilder.RenameColumn(
                name: "RG",
                table: "TB_USUARIOS",
                newName: "REGISTRO_GERAL");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "TB_USUARIOS",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TB_USUARIOS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TB_USUARIOS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "TB_USUARIOS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TB_USUARIOS",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Registration",
                table: "TB_USUARIOS",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_USUARIOS",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_USUARIOS",
                table: "TB_USUARIOS",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_TB_USUARIOS_ClientId",
                        column: x => x.ClientId,
                        principalTable: "TB_USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_TB_USUARIOS_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TB_USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_TB_USUARIOS_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "TB_USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "Email único",
                table: "TB_USUARIOS",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIOS_Name_CPF",
                table: "TB_USUARIOS",
                columns: new[] { "Name", "CPF" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIOS_UsuarioId",
                table: "TB_USUARIOS",
                column: "UsuarioId",
                unique: true,
                filter: "[UsuarioId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeId",
                table: "Order",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SupervisorId",
                table: "Order",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentUser_TB_USUARIOS_UsersId",
                table: "DepartmentUser",
                column: "UsersId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendAddresses_TB_USUARIOS_UserId",
                table: "SendAddresses",
                column: "UserId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_USUARIOS_Contacts_UsuarioId",
                table: "TB_USUARIOS",
                column: "UsuarioId",
                principalTable: "Contacts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentUser_TB_USUARIOS_UsersId",
                table: "DepartmentUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SendAddresses_TB_USUARIOS_UserId",
                table: "SendAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_USUARIOS_Contacts_UsuarioId",
                table: "TB_USUARIOS");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_USUARIOS",
                table: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "Email único",
                table: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIOS_Name_CPF",
                table: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIOS_UsuarioId",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "Registration",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_USUARIOS");

            migrationBuilder.RenameTable(
                name: "TB_USUARIOS",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "REGISTRO_GERAL",
                table: "Users",
                newName: "RG");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "RegisterDate",
                table: "Users",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserId",
                table: "Contacts",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Users_UserId",
                table: "Contacts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentUser_Users_UsersId",
                table: "DepartmentUser",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SendAddresses_Users_UserId",
                table: "SendAddresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
