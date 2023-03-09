using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesErrorsFixed_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_authors_AuthorId",
                table: "authors_books");

            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_books_BookId",
                table: "authors_books");

            migrationBuilder.DropIndex(
                name: "IX_authors_books_AuthorId",
                table: "authors_books");

            migrationBuilder.DropIndex(
                name: "IX_authors_books_BookId",
                table: "authors_books");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "authors_books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "authors_books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "authors_books",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BookId",
                table: "authors_books",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_authors_books_AuthorId",
                table: "authors_books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_authors_books_BookId",
                table: "authors_books",
                column: "BookId");

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
    }
}
