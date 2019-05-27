using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lesson17
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IConfiguration config)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html";
                Func<String> test = () =>
                {
                    if (true) throw new Exception();
                    return "test";
                }; 
                await context.Response.WriteAsync($"<h1>{config["AppName"]}</h1>" +
                                                  //$"{test()}" +
                                                  $"<p>Env: {env.EnvironmentName}</p>" +
                                                  $"<p>ApplicationName: {env.ApplicationName}</p>" +
                                                  $"<p>WebRootPat: {env.WebRootPath}</p>" +
                                                  $"<p>ContentRootPath: {env.ContentRootPath}</p>" +
                                                  $"<p>Default connection: {config.GetConnectionString("DefaultConnection")}</p>" +
                                                  $"<p>MySql connection: {config.GetSection("ConnectionStrings")["MySqlConnection"]}");
            });
        }
    }
}
