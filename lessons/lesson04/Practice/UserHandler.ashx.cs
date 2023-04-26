using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    /// <summary>
    /// Summary description for UserHandler
    /// </summary>
    public class UserHandler : IHttpHandler
    {
        private object action;

        public UserHandler(object action)
        {
            this.action = action;
        }

        public void ProcessRequest(HttpContext context)
        {
            var action = this.action?.ToString();
            var page = string.IsNullOrEmpty(action) ? "Index" : action;
            context.Server.Transfer($"~/Views/User/{page}.aspx");
        }

        public bool IsReusable => false;
    }
}