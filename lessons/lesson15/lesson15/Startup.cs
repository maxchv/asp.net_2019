using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace lesson15
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // middleware - (промежуточный) обработчик HTTP запроса

            //app.Use(async (context, next) =>
            //{
            //    context.Response.ContentType = "text/html";
            //    await next.Invoke(); // передача обработки запроса по цепочке обработчиков
            //    await context.Response.WriteAsync("<br/>End first");
            //});

            //string a = "";

            //app.Use(async (context, next) =>
            //{
            //    a = context.Request.Query["name"].ToString();
            //    //await next.Invoke(); // передача обработки запроса по цепочке обработчиков
            //    await context.Response.WriteAsync("<br/>End second");
            //});
            //app.UseMiddleware<TokenMiddleware>();
            //app.UseToken();

            app.UseStaticFiles(); // подключение статических файлов
            //app.UseDirectoryBrowser();
            
            app.Map("/home", (_app) =>
            {
                _app.Run(async context => { await context.Response.WriteAsync("Home page"); });
            });

            app.Map("/index", Index);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<head><link rel='stylesheet' href='/css/style.css'/></head>Page not found");
            });
        }

        private void Index(IApplicationBuilder app)
        {
            app.Map("/test",  _app =>
            {
                _app.Run(async context => await context.Response.WriteAsync("Test page"));
            });
            app.Run(async context => { await context.Response.WriteAsync("Index page"); });
        }
    }
}
