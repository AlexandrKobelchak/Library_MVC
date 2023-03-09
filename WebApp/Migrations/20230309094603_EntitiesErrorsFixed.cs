using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesErrorsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_books_BookId",
                table: "authors_books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_categories_CategoryId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_press_PressId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_themes_ThemeId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_s_cards_books_BookId",
                table: "s_cards");

            migrationBuilder.DropForeignKey(
                name: "FK_s_cards_students_StudentId",
                table: "s_cards");

            migrationBuilder.DropForeignKey(
                name: "FK_t_cards_books_BookId",
                table: "t_cards");

            migrationBuilder.DropForeignKey(
                name: "FK_t_cards_teachers_TeacherId",
                table: "t_cards");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "t_cards",
                newName: "id_teacher");

            migrationBuilder.RenameColumn(
                name: "DateOut",
                table: "t_cards",
                newName: "date_out");

            migrationBuilder.RenameColumn(
                name: "DateIn",
                table: "t_cards",
                newName: "date_in");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "t_cards",
                newName: "id_book");

            migrationBuilder.RenameIndex(
                name: "IX_t_cards_TeacherId",
                table: "t_cards",
                newName: "IX_t_cards_id_teacher");

            migrationBuilder.RenameIndex(
                name: "IX_t_cards_BookId",
                table: "t_cards",
                newName: "IX_t_cards_id_book");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "s_cards",
                newName: "id_student");

            migrationBuilder.RenameColumn(
                name: "DateOut",
                table: "s_cards",
                newName: "date_out");

            migrationBuilder.RenameColumn(
                name: "DateIn",
                table: "s_cards",
                newName: "date_in");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "s_cards",
                newName: "id_book");

            migrationBuilder.RenameIndex(
                name: "IX_s_cards_StudentId",
                table: "s_cards",
                newName: "IX_s_cards_id_student");

            migrationBuilder.RenameIndex(
                name: "IX_s_cards_BookId",
                table: "s_cards",
                newName: "IX_s_cards_id_book");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "books",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "ThemeId",
                table: "books",
                newName: "id_theme");

            migrationBuilder.RenameColumn(
                name: "PressId",
                table: "books",
                newName: "id_press");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "books",
                newName: "id_category");

            migrationBuilder.RenameIndex(
                name: "IX_books_ThemeId",
                table: "books",
                newName: "IX_books_id_theme");

            migrationBuilder.RenameIndex(
                name: "IX_books_PressId",
                table: "books",
                newName: "IX_books_id_press");

            migrationBuilder.RenameIndex(
                name: "IX_books_CategoryId",
                table: "books",
                newName: "IX_books_id_category");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "authors_books",
                newName: "BookId1");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_BookId",
                table: "authors_books",
                newName: "IX_authors_books_BookId1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_out",
                table: "t_cards",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_in",
                table: "t_cards",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_out",
                table: "s_cards",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_in",
                table: "s_cards",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_books_BookId1",
                table: "authors_books",
                column: "BookId1",
                principalTable: "books",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_categories_id_category",
                table: "books",
                column: "id_category",
                principalTable: "categories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_press_id_press",
                table: "books",
                column: "id_press",
                principalTable: "press",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_themes_id_theme",
                table: "books",
                column: "id_theme",
                principalTable: "themes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_s_cards_books_id_book",
                table: "s_cards",
                column: "id_book",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_s_cards_students_id_student",
                table: "s_cards",
                column: "id_student",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_cards_books_id_book",
                table: "t_cards",
                column: "id_book",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_cards_teachers_id_teacher",
                table: "t_cards",
                column: "id_teacher",
                principalTable: "teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_books_books_BookId1",
                table: "authors_books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_categories_id_category",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_press_id_press",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_themes_id_theme",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_s_cards_books_id_book",
                table: "s_cards");

            migrationBuilder.DropForeignKey(
                name: "FK_s_cards_students_id_student",
                table: "s_cards");

            migrationBuilder.DropForeignKey(
                name: "FK_t_cards_books_id_book",
                table: "t_cards");

            migrationBuilder.DropForeignKey(
                name: "FK_t_cards_teachers_id_teacher",
                table: "t_cards");

            migrationBuilder.RenameColumn(
                name: "id_teacher",
                table: "t_cards",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "id_book",
                table: "t_cards",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "date_out",
                table: "t_cards",
                newName: "DateOut");

            migrationBuilder.RenameColumn(
                name: "date_in",
                table: "t_cards",
                newName: "DateIn");

            migrationBuilder.RenameIndex(
                name: "IX_t_cards_id_teacher",
                table: "t_cards",
                newName: "IX_t_cards_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_t_cards_id_book",
                table: "t_cards",
                newName: "IX_t_cards_BookId");

            migrationBuilder.RenameColumn(
                name: "id_student",
                table: "s_cards",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "id_book",
                table: "s_cards",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "date_out",
                table: "s_cards",
                newName: "DateOut");

            migrationBuilder.RenameColumn(
                name: "date_in",
                table: "s_cards",
                newName: "DateIn");

            migrationBuilder.RenameIndex(
                name: "IX_s_cards_id_student",
                table: "s_cards",
                newName: "IX_s_cards_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_s_cards_id_book",
                table: "s_cards",
                newName: "IX_s_cards_BookId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "books",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "id_theme",
                table: "books",
                newName: "ThemeId");

            migrationBuilder.RenameColumn(
                name: "id_press",
                table: "books",
                newName: "PressId");

            migrationBuilder.RenameColumn(
                name: "id_category",
                table: "books",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_books_id_theme",
                table: "books",
                newName: "IX_books_ThemeId");

            migrationBuilder.RenameIndex(
                name: "IX_books_id_press",
                table: "books",
                newName: "IX_books_PressId");

            migrationBuilder.RenameIndex(
                name: "IX_books_id_category",
                table: "books",
                newName: "IX_books_CategoryId");

            migrationBuilder.RenameColumn(
                name: "BookId1",
                table: "authors_books",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_authors_books_BookId1",
                table: "authors_books",
                newName: "IX_authors_books_BookId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOut",
                table: "t_cards",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "t_cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOut",
                table: "s_cards",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "s_cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_authors_books_books_BookId",
                table: "authors_books",
                column: "BookId",
                principalTable: "books",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_categories_CategoryId",
                table: "books",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_press_PressId",
                table: "books",
                column: "PressId",
                principalTable: "press",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_themes_ThemeId",
                table: "books",
                column: "ThemeId",
                principalTable: "themes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_s_cards_books_BookId",
                table: "s_cards",
                column: "BookId",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_s_cards_students_StudentId",
                table: "s_cards",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_cards_books_BookId",
                table: "t_cards",
                column: "BookId",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_t_cards_teachers_TeacherId",
                table: "t_cards",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
