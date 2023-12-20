using Empire.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Empire.Areas.Identity.Data;

/*Credits: 
RazorPages applikation og projekt startet af Nuriye og Gülsüm Erdogan*/

namespace Empire
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddRazorPages();

            // Configure ApplicationDbContext
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
            ));

            // configure Identity with Application DbContext
            builder.Services.AddDefaultIdentity<EmpireUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Konfigurerer Empire Db Context (using ADO.NET connection)
            builder.Services.AddDbContext<EmpireContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("AdoConnection")
            ));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
