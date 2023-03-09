using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class LibratyMigration_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("1c0e3929-e694-4c7c-87eb-593fb8ab878f"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("1e4db1b3-f2dd-4031-8610-2bd4be6fe0cd"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("a6d3711e-f12e-48cd-abc3-ecbaec984736"));

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "faculties",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("162767f4-e375-4451-9568-7bba759ddbf7"), "Программирования" },
                    { new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"), "Компьютерной графики и дизайна" },
                    { new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"), "Администрирования" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("162767f4-e375-4451-9568-7bba759ddbf7"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "students",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "groups",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "faculties",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("1c0e3929-e694-4c7c-87eb-593fb8ab878f"), "Администрирования" },
                    { new Guid("1e4db1b3-f2dd-4031-8610-2bd4be6fe0cd"), "Компьютерной графики и дизайна" },
                    { new Guid("a6d3711e-f12e-48cd-abc3-ecbaec984736"), "Программирования" }
                });
        }
    }
}
