using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson11.Filters
{
    public class MyActionFilterAttribute: FilterAttribute, IActionFilter, IResultFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Start filter");
            if (filterContext.HttpContext.Request.Cookies["test"] != null)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("End filter");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("Start result");
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("End result");
        }
    }
}