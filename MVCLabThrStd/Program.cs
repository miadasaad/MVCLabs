using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MVCLabThrStd.Models;
using MVCLabThrStd.Services;

namespace MVCLabThrStd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IDepartment, DepartmentDb>();
            builder.Services.AddDbContext<ITI>(a =>
            {
                a.UseSqlServer("Server=.;Database=MVC1;Trusted_Connection=true");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("testing");
            //});

            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("first middleware");
            //    await next();
            //    await context.Response.WriteAsync("back to first middleware");

            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("second middleware");

            //    await next();
            //});
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}