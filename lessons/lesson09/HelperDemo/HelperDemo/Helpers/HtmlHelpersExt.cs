using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperDemo.Helpers
{
    public static class HtmlHelpersExt
    {
        public static MvcHtmlString CurrentDate(this HtmlHelper helper)
        {
            return MvcHtmlString.Create($"<div>{DateTime.Now}</div>");
        }
    }
}