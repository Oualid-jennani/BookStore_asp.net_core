using Bookstore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            /*
            var webHost = CreateWebHostBuilder(args).Build();
            RunMigrations(webHost);
            webHost.Run();
            */
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

       /*
       private static void RunMigrations(IWebHost webHost)
       {
           using (var scope = webHost.Services.CreateScope())
           {
               var db = scope.ServiceProvider.GetRequiredService<BookstoreDbContext>();
               db.Database.Migrate();
           }
       }

       public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>();
       */
    }
}
