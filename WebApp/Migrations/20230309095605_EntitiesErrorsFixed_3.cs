using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesErrorsFixed_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_authors_AuthorId1",
                table: "authors_books");

            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_books_BookId1",
                table: "authors_books");

            migrationBuilder.RenameColumn(
                name: "BookId1",
                table: "authors_books",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "AuthorId1",
                table: "authors_books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_BookId1",
                table: "authors_books",
                newName: "IX_authors_books_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_AuthorId1",
                table: "authors_books",
                newName: "IX_authors_books_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_authors_AuthorId",
                table: "authors_books",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_books_BookId",
                table: "authors_books",
                column: "BookId",
                principalTable: "books",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_authors_AuthorId",
                table: "authors_books");

            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_books_BookId",
                table: "authors_books");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "authors_books",
                newName: "BookId1");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "authors_books",
                newName: "AuthorId1");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_BookId",
                table: "authors_books",
                newName: "IX_authors_books_BookId1");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_AuthorId",
                table: "authors_books",
                newName: "IX_authors_books_AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_authors_AuthorId1",
                table: "authors_books",
                column: "AuthorId1",
                principalTable: "authors",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_books_BookId1",
                table: "authors_books",
                column: "BookId1",
                principalTable: "books",
                principalColumn: "id");
        }
    }
}
