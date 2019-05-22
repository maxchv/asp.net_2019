using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lesson16.Middleware;
using lesson16.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lesson16
{
    public class Startup
    {
        private IServiceCollection _services;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<ISimpleService, SimpleServiceImpl>();
            services.AddTransient<ISimpleService, OtherService>();
            //services.AddTransient<IResponseParam, DefaultResponseParam>();
            services.AddHtml();
            this._services = services;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env,
                              IConfiguration config
                              //, ISimpleService service <- внедрение через аргумент метода
                              )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var service = app.ApplicationServices.GetService<ISimpleService>();

            app.UseHtml();
            app.Run(async (context) =>
            {
                var response = "";
                foreach (var s in _services)
                {
                    response += s.ServiceType + "<br/>";
                }
                await context.Response.WriteAsync(service.Message);
            });
        }
    }
}
