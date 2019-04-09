using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyWebForm
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Label1.Text = "First";
                foreach (string key in Request.Form)
                {
                    Debug.WriteLine($"{key}: {Request.Form[key]}");
                }
            }
            Debug.WriteLine("Page_Load");
            
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongDateString();
            Debug.WriteLine("Button1_OnClick");
        }
    }
}