﻿// <auto-generated />
using System;
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230309094603_EntitiesErrorsFixed")]
    partial class EntitiesErrorsFixed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBooks", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_author");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_book");

                    b.Property<Guid?>("BookId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorId", "BookId");

                    b.HasIndex("BookId");

                    b.HasIndex("BookId1");

                    b.HasIndex("TeacherId");

                    b.ToTable("authors_books", (string)null);
                });

            modelBuilder.Entity("Entities.Identity.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Entities.Identity.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("FirstName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("pk_authors");

                    b.ToTable("authors", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_category");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("name");

                    b.Property<Guid>("PressId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_press");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<Guid>("ThemeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_theme");

                    b.HasKey("Id")
                        .HasName("pk_books");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("PressId");

                    b.HasIndex("ThemeId");

                    b.ToTable("books", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_departments");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("departments", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_faculties");

                    b.ToTable("faculties", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("162767f4-e375-4451-9568-7bba759ddbf7"),
                            Name = "Программирования"
                        },
                        new
                        {
                            Id = new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"),
                            Name = "Администрирования"
                        },
                        new
                        {
                            Id = new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"),
                            Name = "Компьютерной графики и дизайна"
                        });
                });

            modelBuilder.Entity("Entities.Library.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_faculty");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_groups");

                    b.HasIndex("FacultyId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("groups", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Librarian", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("pk_libs");

                    b.ToTable("libs", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Press", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_press");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("press", (string)null);
                });

            modelBuilder.Entity("Entities.Library.SCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_book");

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_in");

                    b.Property<DateTime>("DateOut")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("date_out")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<Guid>("LibrarianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_student");

                    b.HasKey("Id")
                        .HasName("pk_scards");

                    b.HasIndex("BookId");

                    b.HasIndex("LibrarianId");

                    b.HasIndex("StudentId");

                    b.ToTable("s_cards", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("first_name");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_group");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("pk_students");

                    b.HasIndex("GroupId");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("Entities.Library.TCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_book");

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_in");

                    b.Property<DateTime>("DateOut")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("date_out")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<Guid>("LibrarianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_teacher");

                    b.HasKey("Id")
                        .HasName("pk_tcards");

                    b.HasIndex("BookId");

                    b.HasIndex("LibrarianId");

                    b.HasIndex("TeacherId");

                    b.ToTable("t_cards", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_department");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("pk_teachers");

                    b.HasIndex("DepartmentId");

                    b.ToTable("teachers", (string)null);
                });

            modelBuilder.Entity("Entities.Library.Theme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_themes");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("themes", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AuthorBooks", b =>
                {
                    b.HasOne("Entities.Library.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Library.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Library.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId1");

                    b.HasOne("Entities.Library.Author", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("Book");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Entities.Library.Book", b =>
                {
                    b.HasOne("Entities.Library.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Entities.Library.Press", "Press")
                        .WithMany("Books")
                        .HasForeignKey("PressId");

                    b.HasOne("Entities.Library.Theme", "Theme")
                        .WithMany("Books")
                        .HasForeignKey("ThemeId");

                    b.Navigation("Category");

                    b.Navigation("Press");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("Entities.Library.Group", b =>
                {
                    b.HasOne("Entities.Library.Faculty", "Faculty")
                        .WithMany("Groups")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Entities.Library.SCard", b =>
                {
                    b.HasOne("Entities.Library.Book", "Book")
                        .WithMany("SCards")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Library.Librarian", "Librarian")
                        .WithMany("SCards")
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Library.Student", "Student")
                        .WithMany("SCards")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Librarian");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Entities.Library.Student", b =>
                {
                    b.HasOne("Entities.Library.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Entities.Library.TCard", b =>
                {
                    b.HasOne("Entities.Library.Book", "Book")
                        .WithMany("TCards")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Library.Librarian", "Librarian")
                        .WithMany("TCards")
                        .HasForeignKey("LibrarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Library.Teacher", "Teacher")
                        .WithMany("TCards")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Librarian");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Entities.Library.Teacher", b =>
                {
                    b.HasOne("Entities.Library.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Library.Book", b =>
                {
                    b.Navigation("SCards");

                    b.Navigation("TCards");
                });

            modelBuilder.Entity("Entities.Library.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Entities.Library.Department", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Entities.Library.Faculty", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("Entities.Library.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Entities.Library.Librarian", b =>
                {
                    b.Navigation("SCards");

                    b.Navigation("TCards");
                });

            modelBuilder.Entity("Entities.Library.Press", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Entities.Library.Student", b =>
                {
                    b.Navigation("SCards");
                });

            modelBuilder.Entity("Entities.Library.Teacher", b =>
                {
                    b.Navigation("TCards");
                });

            modelBuilder.Entity("Entities.Library.Theme", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
