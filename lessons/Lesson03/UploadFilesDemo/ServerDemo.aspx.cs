using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UploadFilesDemo
{
    public partial class ServerDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            PathToDir.Text = $@"Directory.GetCurrentDirectory(): {Directory.GetCurrentDirectory()}<br/>
            Server.MapPath(""Uploads""): {Server.MapPath("Uploads")}<br/>
            Path.GetRandomFileName() : {Path.GetRandomFileName()}<br/>
            Path.GetTempFileName() : {Path.GetTempFileName()}<br/>
            RawUrl: {Request.RawUrl} <br/>
            Url: {Server.UrlDecode(Request.RawUrl)} <br/>
            Html: {Server.HtmlEncode("<script>alert('hello')</script>")}"; 
        }
    }
}