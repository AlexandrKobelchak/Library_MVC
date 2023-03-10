using Entities.Identity;
using Entities.Library;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Context;

public partial class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public DbSet<Press> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }    
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Librarian> Librarians { get; set; }
    public DbSet<SCard> SCards { get; set; }
    public DbSet<TCard> TCards { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Press> Press { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Author> Authors { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }
}