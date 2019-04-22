using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManualMVC
{
    /// <summary>
    /// Summary description for DefaultHandler
    /// </summary>
    public class DefaultHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Server.Transfer("Default.aspx");
        }

        public bool IsReusable => false;
    }
}