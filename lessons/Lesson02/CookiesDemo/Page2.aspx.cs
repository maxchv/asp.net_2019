using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesDemo
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var key in Request.Cookies.AllKeys)
            {
               Response.Write($"{Request.Cookies[key].Name} = {Request.Cookies[key].Value}<br/>");
            }
            Response.Write(Session["student"]);

        }
    }
}