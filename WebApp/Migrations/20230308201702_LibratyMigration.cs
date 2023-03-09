using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class LibratyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("2770170f-21f1-4b4b-9a98-76a0d4e10be1"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("2770170f-21f1-4b4b-9a98-76a0d4e10be1"), "Программирования" });
        }
    }
}
