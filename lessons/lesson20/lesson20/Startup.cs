using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lesson20
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseWebSockets(options: new WebSocketOptions
            {
                ReceiveBufferSize = 4 * 1024
            });

            app.Use(async (context, next) =>
            {
                var path = context.Request.Path;
                if (path == "/ws" && context.WebSockets.IsWebSocketRequest)
                {
                    // ReSharper disable once CommentTypo
                    // запрос на установку соедиенения по WebSocket
                    var webSocket = await context.WebSockets.AcceptWebSocketAsync();
                    var buffer = new byte[1024 * 4]; // буфер
                    // получаем первое сообщение
                    var receive = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    while (!receive.CloseStatus.HasValue) // до тех пор, пока открыто соединение
                    {
                        // отправляем ответ
                        await webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, receive.Count), 
                                                  receive.MessageType, receive.EndOfMessage, CancellationToken.None);
                        // получаем очередное сообщение
                        receive = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    }
                    // закрываем соединение
                    await webSocket.CloseAsync(receive.CloseStatus.Value, receive.CloseStatusDescription,
                        CancellationToken.None);
                }
                else
                {
                    await next();
                }
            });

            app.UseMvc();
        }
    }
}
