using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesErrorsFixed_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_authors_TeacherId",
                table: "authors_books");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "authors_books",
                newName: "AuthorId1");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_TeacherId",
                table: "authors_books",
                newName: "IX_authors_books_AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_authors_AuthorId1",
                table: "authors_books",
                column: "AuthorId1",
                principalTable: "authors",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_authors_AuthorId1",
                table: "authors_books");

            migrationBuilder.RenameColumn(
                name: "AuthorId1",
                table: "authors_books",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_AuthorId1",
                table: "authors_books",
                newName: "IX_authors_books_TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_authors_TeacherId",
                table: "authors_books",
                column: "TeacherId",
                principalTable: "authors",
                principalColumn: "id");
        }
    }
}
