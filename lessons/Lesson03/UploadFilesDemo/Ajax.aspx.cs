using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadFilesDemo
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString();
            Label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}