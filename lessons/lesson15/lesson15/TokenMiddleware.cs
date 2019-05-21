using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace lesson15
{
    public class TokenMiddleware
    {
        private RequestDelegate _next;
        public TokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];
            if (token != "12345")
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Deny");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
