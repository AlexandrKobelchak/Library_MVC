using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class errors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "press",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("162767f4-e375-4451-9568-7bba759ddbf7"), "Программирования" },
                    { new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"), "Администрирования" },
                    { new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"), "Компьютерной графики и дизайна" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "press",
                keyColumn: "id",
                keyValue: new Guid("162767f4-e375-4451-9568-7bba759ddbf7"));

            migrationBuilder.DeleteData(
                table: "press",
                keyColumn: "id",
                keyValue: new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"));

            migrationBuilder.DeleteData(
                table: "press",
                keyColumn: "id",
                keyValue: new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"));

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("162767f4-e375-4451-9568-7bba759ddbf7"), "Программирования" },
                    { new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"), "Администрирования" },
                    { new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"), "Компьютерной графики и дизайна" }
                });
        }
    }
}
