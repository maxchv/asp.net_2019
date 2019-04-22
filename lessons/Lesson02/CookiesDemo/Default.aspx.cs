using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListBox1.DataSource = new List<Student>
                {
                    new Student {Name = "Вася"},
                    new Student {Name = "Маша"},
                    new Student {Name = "Рома"},
                };
                ListBox1.DataValueField = "Id";
                ListBox1.DataTextField = "Name";
                ListBox1.DataBind();
                DropDownList1.DataSource = ListBox1.DataSource;
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataBind();
            }

            string allCookies = "";
            foreach (var key in Request.Cookies.AllKeys)
            {
                allCookies += $"{Request.Cookies[key].Name} = {Request.Cookies[key].Value}<br/>";
            }

            Session["student"] = new Student { Name="Вася" };
            Label2.Text = allCookies;
        }

        protected void CheckBox1_OnCheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = CheckBox1.Checked ? "Yes" : "No";
            Response.SetCookie(new HttpCookie("checkbox", Label1.Text));
        }

        protected void ListBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = ListBox1.SelectedValue;
        }

        protected void DropDownList1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }

    public class Student
    {
        private static int _count;
        public int Id { get; private set; }
        public string Name { get; set; }

        public Student()
        {
            Id = ++_count;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}