using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UploadFilesDemo
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly string _uploads;
        private readonly string _uploadsPath;

        public Default()
        {
            _uploads = "Uploads";
            _uploadsPath = Server.MapPath(_uploads);
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            BindFileList();
        }

        private void BindFileList()
        {
            var links = Directory.GetFiles(_uploadsPath)
                .Select(s => new FileInfo(s).Name)
                .Select(f => new {Text = f, Url = $"./{_uploads}/{f}"});

            BulletedList1.DataSource = links;
            BulletedList1.DataTextField = "Text";
            BulletedList1.DataValueField = "Url";
            BulletedList1.DataBind();
        }

        protected void Upload(object sender, EventArgs e)
        {
            if (!FileUpload1.HasFile) return;

            FileUpload1.SaveAs(Path.Combine(_uploadsPath, FileUpload1.FileName));
            Response.Redirect("Default.aspx");
        }
    }
}