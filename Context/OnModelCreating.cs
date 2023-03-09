using Entities.Identity;
using Entities.Library;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Context;

public partial class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    void OnCreateFaculty(EntityTypeBuilder<Faculty> e)
    {
        e.ToTable("faculties");
        e.HasKey(e => e.Id)
         .HasName("pk_faculties");

        e.Property(f => f.Id)
         .HasColumnName("id")
         //.ValueGeneratedOnAdd()
         .HasDefaultValueSql("NEWID()"); ;

        e.Property(e => e.Name)
            .HasColumnName("name")
            .IsRequired(true)
            .IsUnicode(true)
            .HasMaxLength(64);
    }
    void OnCreateDepartment(EntityTypeBuilder<Department> e)
    {
        e.ToTable("departments");
        e.HasKey(e => e.Id)
         .HasName("pk_departments");

        e.Property(f => f.Id)
         .HasColumnName("id")
         //.ValueGeneratedOnAdd()
         .HasDefaultValueSql("NEWID()"); ;

        e.Property(e => e.Name)
            .HasColumnName("name")
            .IsRequired(true)
            .IsUnicode(true)
            .HasMaxLength(64);
    }
    void OnCreateGroup(EntityTypeBuilder<Group> e)
    {
        e.ToTable("groups");
        e.HasKey(e => e.Id)
         .HasName("pk_groups");

        e.Property(f => f.Id)
         .HasColumnName("id")
         .HasDefaultValueSql("NEWID()"); ;

        e.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(64)
            .IsRequired(true)
            .IsUnicode(true);

        e.Property(e => e.FacultyId)
           .HasColumnName("id_faculty");

        e.HasOne(e => e.Faculty)
            .WithMany(e => e.Groups)
            .HasForeignKey(e => e.FacultyId);
    }
    void OnCreateStudent(EntityTypeBuilder<Student> e)
    {
        e.ToTable("students");
        e.HasKey(e => e.Id)
         .HasName("pk_students");

        e.Property(f => f.Id)
         .HasColumnName("id")
         .HasDefaultValueSql("NEWID()"); ;


        e.Property(e => e.FirstName)
            .HasColumnName("first_name")
            .HasMaxLength(128)
            .IsRequired(true);

        e.Property(e => e.GroupId)
          .HasColumnName("id_group");

        e.Property(e => e.LastName)
            .HasColumnName("last_name")
            .HasMaxLength(128)
            .IsRequired(true);

        e.HasOne(e => e.Group)
            .WithMany(e => e.Students)
            .HasForeignKey(e => e.GroupId)
            .IsRequired(false);
    }
    void OnCreateTeacher(EntityTypeBuilder<Teacher> e)
    {
        e.ToTable("teachers");
        e.HasKey(e => e.Id)
         .HasName("pk_teachers");

        e.Property(f => f.Id)
         .HasColumnName("id")
         .HasDefaultValueSql("NEWID()"); ;


        e.Property(e => e.FirstName)
            .HasColumnName("first_name")
            .HasMaxLength(128)
            .IsRequired(true);

        e.Property(e => e.DepartmentId)
          .HasColumnName("id_department");

        e.Property(e => e.LastName)
            .HasColumnName("last_name")
            .HasMaxLength(128)
            .IsRequired(true);

        e.HasOne(e => e.Department)
            .WithMany(e => e.Teachers)
            .HasForeignKey(e => e.DepartmentId)
            .IsRequired(true);
    }
    void OnCreateAuthor(EntityTypeBuilder<Author> e)
    {
        e.ToTable("authors");
        e.HasKey(e => e.Id)
         .HasName("pk_authors");

        e.Property(f => f.Id)
         .HasColumnName("id")
         .HasDefaultValueSql("NEWID()"); ;


        e.Property(e => e.FirstName)
            .HasColumnName("first_name")
            .HasMaxLength(128)
            .IsRequired(false);

        e.Property(e => e.LastName)
            .HasColumnName("last_name")
            .HasMaxLength(128)
            .IsRequired(false);
    }
    void OnCreateLibrarian(EntityTypeBuilder<Librarian> e)
    {
        e.ToTable("libs");
        e.HasKey(e => e.Id)
         .HasName("pk_libs");

        e.Property(f => f.Id)
         .HasColumnName("id")
         .HasDefaultValueSql("NEWID()"); ;


        e.Property(e => e.FirstName)
            .HasColumnName("first_name")
            .HasMaxLength(128)
            .IsRequired(true);

        e.Property(e => e.LastName)
            .HasColumnName("last_name")
            .HasMaxLength(128)
            .IsRequired(true);
    }
    void OnCreateBook(EntityTypeBuilder<Book> e)
    {
        e.ToTable("books");

        e.HasKey(x => x.Id)
         .HasName("pk_books");

        e.Property(x => x.Id)
         .HasColumnName("id").
         HasDefaultValueSql("NEWID()"); ;

        e.HasIndex(x => x.Name)
         .IsUnique();

        e.Property(x => x.Name)
         .IsRequired()
         .HasMaxLength(128)
         .HasColumnName("name");

        e.Property(x => x.Description)
         .IsRequired(false)
         .HasMaxLength(1024)
         .HasColumnName("description");

        e.HasOne(x=>x.Theme)
            .WithMany(x=>x.Books)
            .HasForeignKey(x => x.ThemeId)
            .IsRequired(false);

        e.HasOne(x => x.Category)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.CategoryId)
            .IsRequired(false);

        e.HasOne(x => x.Press)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.PressId)
            .IsRequired(false);

        e.HasMany(x => x.Authors)
         .WithMany(x => x.Books)
         .UsingEntity<AuthorBookRelation>("AuthorBooks",
            x => x.HasOne<Author>().WithMany().HasForeignKey("id_author"),
            x => x.HasOne<Book>().WithMany().HasForeignKey("id_book"),
            x =>
            {
                x.HasKey("id_author", "id_book");
                x.ToTable("authors_books");
            });
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Faculty>(OnCreateFaculty);
        builder.Entity<Group>(OnCreateGroup);
        builder.Entity<Student>(OnCreateStudent);
      
        builder.Entity<Department>(OnCreateDepartment);
        builder.Entity<Teacher>(OnCreateTeacher);
        builder.Entity<Librarian>(OnCreateLibrarian);
        builder.Entity<Author>(OnCreateAuthor);


        builder.Entity<Book>(OnCreateBook);


        builder.Entity<Faculty>().HasData(new Faculty { Id= new Guid("162767f4-e375-4451-9568-7bba759ddbf7"), Name = "Программирования" });
        builder.Entity<Faculty>().HasData(new Faculty { Id= new Guid("16fe2a8c-bd23-45af-a1f0-cacd67cfaf3b"), Name = "Администрирования" });
        builder.Entity<Faculty>().HasData(new Faculty { Id= new Guid("2b71cbb1-2783-4b70-bffa-f1e196015ba6"), Name = "Компьютерной графики и дизайна" });
    }
}


