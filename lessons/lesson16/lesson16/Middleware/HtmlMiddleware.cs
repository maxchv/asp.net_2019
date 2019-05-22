using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lesson16.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace lesson16.Middleware
{
    public class HtmlMiddleware
    {
        private RequestDelegate _next;

        public HtmlMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context, IResponseParam param)
        {
            context.Response.ContentType = param.ContentType;
            await _next.Invoke(context);
        }
    }

    public static class HtmlMiddlewareExt
    {
        public static void UseHtml(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<HtmlMiddleware>();
        }
    }
}
