using Microsoft.AspNetCore.Mvc;

namespace SchoolManagment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            #region built in
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
                name:"Student",
                pattern: "std/{action=GetAll}/{id?}",
                defaults: new {controller="student"}
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}/{name?}");

            // app.MapFallbackToController("Error", "Home");
            app.MapFallbackToFile("/html/404Error.html");
            #endregion


            #region Custom
            //app.Use(async (context, next) =>
            //{
            //    // context.Response.ContentType = "Text";
            //    //await context.Response.WriteAsync("middleware 1 \n");
            //    Console.WriteLine("middleware 1 \n");
            //    await next();
            //    Console.WriteLine("middleware 1 backward\n");
            //});

            ////app.Run(async (context) =>
            ////{
            ////    Console.WriteLine("Request terminated");
            ////});

            //app.Use(async (context, next) =>
            //{
            //    // await context.Response.WriteAsync("middleware 2 \n");
            //    Console.WriteLine("middleware 2 \n");
            //    if (context.Request.Path != "/short") {
            //        await next();
            //    }
            //    Console.WriteLine("middleware 2 backward\n");

            //});

            //app.Use(async (context, next) =>
            //{
            //    // await context.Response.WriteAsync("middleware 2 \n");
            //    Console.WriteLine("middleware 3 \n");
            //    await next();
            //    Console.WriteLine("middleware 3 backward\n");

            //});

            //app.Map("/maprequest", () => { Console.WriteLine("Mapped"); });

            #endregion
            app.Run();
        }
    }
}