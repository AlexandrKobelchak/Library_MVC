using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    first_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "libs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    first_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_libs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "press",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_press", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "themes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_themes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    first_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    id_department = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_teachers", x => x.id);
                    table.ForeignKey(
                        name: "FK_teachers_departments_id_department",
                        column: x => x.id_department,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_books", x => x.id);
                    table.ForeignKey(
                        name: "FK_books_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_books_press_PressId",
                        column: x => x.PressId,
                        principalTable: "press",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_books_themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "themes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "authors_books",
                columns: table => new
                {
                    id_author = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id_book = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors_books", x => new { x.id_author, x.id_book });
                    table.ForeignKey(
                        name: "FK_authors_books_authors_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "authors",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_authors_books_authors_id_author",
                        column: x => x.id_author,
                        principalTable: "authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_authors_books_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_authors_books_books_id_book",
                        column: x => x.id_book,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "s_cards",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibrarianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_scards", x => x.id);
                    table.ForeignKey(
                        name: "FK_s_cards_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_s_cards_libs_LibrarianId",
                        column: x => x.LibrarianId,
                        principalTable: "libs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_s_cards_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "t_cards",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibrarianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tcards", x => x.id);
                    table.ForeignKey(
                        name: "FK_t_cards_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_cards_libs_LibrarianId",
                        column: x => x.LibrarianId,
                        principalTable: "libs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_t_cards_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"),
                column: "name",
                value: "Администрирования");

            migrationBuilder.UpdateData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"),
                column: "name",
                value: "Компьютерной графики и дизайна");

            migrationBuilder.CreateIndex(
                name: "IX_groups_name",
                table: "groups",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_authors_books_BookId",
                table: "authors_books",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_authors_books_id_book",
                table: "authors_books",
                column: "id_book");

            migrationBuilder.CreateIndex(
                name: "IX_authors_books_TeacherId",
                table: "authors_books",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_books_CategoryId",
                table: "books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_books_name",
                table: "books",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_books_PressId",
                table: "books",
                column: "PressId");

            migrationBuilder.CreateIndex(
                name: "IX_books_ThemeId",
                table: "books",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_categories_name",
                table: "categories",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_departments_name",
                table: "departments",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_press_name",
                table: "press",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_s_cards_BookId",
                table: "s_cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_s_cards_LibrarianId",
                table: "s_cards",
                column: "LibrarianId");

            migrationBuilder.CreateIndex(
                name: "IX_s_cards_StudentId",
                table: "s_cards",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_t_cards_BookId",
                table: "t_cards",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_t_cards_LibrarianId",
                table: "t_cards",
                column: "LibrarianId");

            migrationBuilder.CreateIndex(
                name: "IX_t_cards_TeacherId",
                table: "t_cards",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_id_department",
                table: "teachers",
                column: "id_department");

            migrationBuilder.CreateIndex(
                name: "IX_themes_name",
                table: "themes",
                column: "name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "authors_books");

            migrationBuilder.DropTable(
                name: "s_cards");

            migrationBuilder.DropTable(
                name: "t_cards");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "libs");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "press");

            migrationBuilder.DropTable(
                name: "themes");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropIndex(
                name: "IX_groups_name",
                table: "groups");

            migrationBuilder.UpdateData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"),
                column: "name",
                value: "Компьютерной графики и дизайна");

            migrationBuilder.UpdateData(
                table: "faculties",
                keyColumn: "id",
                keyValue: new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"),
                column: "name",
                value: "Администрирования");
        }
    }
}
