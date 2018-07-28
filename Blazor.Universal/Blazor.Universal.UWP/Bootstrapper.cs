using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Blazor.Universal.UWP
{
    public class Bootstrapper
    {
        static Bootstrapper() => Console.SetOut(new ToDebugWriter());

        public static void Bootstrap() => BuildWebHost(null).Start();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:55300")
                .UseStartup<Startup>();

        public static IWebHost BuildWebHost(string[] args) =>
            CreateWebHostBuilder(args).Build();

        public class Startup
        {
            public void ConfigureServices(IServiceCollection _) => _.AddServerSideBlazor<Universal.Startup>();

            public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
            {
                if (env.IsDevelopment())
                    app.UseDeveloperExceptionPage();
                
                app.UseServerSideBlazor<Universal.Startup>();
            }
        }
    }
}