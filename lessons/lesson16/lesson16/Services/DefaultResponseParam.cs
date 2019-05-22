using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace lesson16.Services
{
    public class DefaultResponseParam: IResponseParam
    {
        public string ContentType { get; set; } = "text/html; charset=utf-8";
    }

    public static class HtmlResponseExt
    {
        public static void AddHtml(this IServiceCollection collection)
        {
            collection.AddTransient<IResponseParam, DefaultResponseParam>();
        }
    }
}
