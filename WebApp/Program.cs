using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Context;
using Entities.Identity;
using Microsoft.AspNetCore.Authorization;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

            builder.Services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(connectionString,
                ob=>ob.MigrationsAssembly("WebApp")));

            builder.Services.AddDefaultIdentity<AppUser>()
                .AddRoles<AppRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;

                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 1;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.AllowedForNewUsers = false;

            });

            builder.Services.Configure<AuthorizationOptions>(options =>
            {
                options.AddPolicy("RequireUser", policy =>
                    policy.RequireAuthenticatedUser());

                options.AddPolicy("RequireModerator", policy =>
                    policy.RequireRole("Administrators", "Moderators")
                          .RequireAuthenticatedUser());

                options.AddPolicy("RequireAdministrator", policy =>
                    policy.RequireRole("Administrators")
                          .RequireAuthenticatedUser());

                options.AddPolicy("Student", policy =>
                   policy.RequireRole("Teachers", "Students")
                         .RequireAuthenticatedUser());

                options.AddPolicy("Teacher", policy =>
                  policy.RequireRole("Teachers")
                        .RequireAuthenticatedUser());

            });

            var app = builder.Build();

            using(var serviceScope = app.Services.GetService<IServiceScopeFactory>()?.CreateScope())
            {
                AppDbContext? context = serviceScope?.ServiceProvider.GetRequiredService<AppDbContext>();
                if(context!=null)
                {
                    context.Database.Migrate();
                }
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            
            app.MapRazorPages();

            app.Run();
        }
    }
}