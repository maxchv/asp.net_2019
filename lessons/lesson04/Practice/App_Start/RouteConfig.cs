using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Practice.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRouters(RouteCollection routers)
        {
            routers.Add(new Route("{controller}/{action}/{*id}",
                new RouteValueDictionary
                {
                    {"controller","Home"},
                    {"action", "Index" }
                }, new MyHandler()));
        }
    }

    public class MyHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            IHttpHandler handler = null;

            switch (requestContext.RouteData.Values["controller"]?.ToString())
            {
                case "User":
                    handler = new UserHandler(requestContext.RouteData.Values["action"]);
                    break;
                case "Home":
                default:
                    handler = new HomeHandler();
                    break;
            }
            return handler;
        }
    }
}