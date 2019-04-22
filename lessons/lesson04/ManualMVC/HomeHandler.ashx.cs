using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManualMVC
{
    /// <summary>
    /// Summary description for HomeHandler
    /// </summary>
    public class HomeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Server.Transfer("Home.aspx");
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