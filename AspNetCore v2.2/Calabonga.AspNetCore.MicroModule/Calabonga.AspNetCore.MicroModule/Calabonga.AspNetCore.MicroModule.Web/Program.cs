﻿using Calabonga.AspNetCore.MicroModule.Data.DatabaseInitialization;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Calabonga.AspNetCore.MicroModule.Web
{
    /// <summary>
    /// Entry point
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var webHost = CreateWebHostBuilder(args).Build();
            using (var scope = webHost.Services.CreateScope())
            {
                DatabaseInitializer.Seed(scope.ServiceProvider);
            }
            webHost.Run();
        }

        /// <summary>
        /// Create web host
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
