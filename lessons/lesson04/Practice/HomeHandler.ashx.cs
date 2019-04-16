using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice
{
    /// <summary>
    /// Summary description for HomeHandler
    /// </summary>
    public class HomeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Server.Transfer("~/Views/Home/Index.aspx");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}