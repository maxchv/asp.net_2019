using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ManualMVC
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRouters(RouteTable.Routes);
        }

        private void RegisterRouters(RouteCollection routes)
        {
            routes.Add(new Route("{controller}/{*action}",
                new RouteValueDictionary
                {
                    { "controller", "Home"}
                },
                new MyRouteHandler()));
            //routes.MapPageRoute("Default",   // имя маршрута
            //        "{controller}/{action}/{*id}",  // шаблон маршрута
            //    "~/Default.aspx",          // куда направляется запрос
            //        true,          // проверять наличие файла
            //        new RouteValueDictionary          // значения по умолчанию для маршрута
            //        {
            //            { "controller", "Home" },
            //            { "action", "Index" }
            //        },
            //        new RouteValueDictionary // ограничения на маршрут
            //        {
            //            { "controller", @"\w*" },
            //            { "action", @"\w*" },
            //            { "id", @"\d*" }
            //        });
        }
    }

    internal class MyRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            var controller = requestContext.RouteData.Values["controller"];
            if (controller.ToString() == "Home")
            {
                return new HomeHandler();
            }
            return new DefaultHandler();
        }
    }
}