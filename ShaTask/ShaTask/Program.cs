using Microsoft.EntityFrameworkCore;
using ShaTask.Application;
using ShaTask.Infrastructre;
using ShaTask.Infrastructre.Presstance;

namespace ShaTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.InfraInjection();
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(ApplicationDIInjection).Assembly));
            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnection")
                    , m => m.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Cashier}/{action=Index}/{id?}");

            app.Run();
        }
    }
}