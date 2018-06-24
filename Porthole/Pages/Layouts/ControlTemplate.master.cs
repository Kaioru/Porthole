using System;
using System.Web.UI;
using Porthole.Models;

namespace Porthole.Pages.Layouts
{
    public partial class ControlTemplate : System.Web.UI.MasterPage
    {
        public string Test { get; set; }
        public IAccount Account { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Account = (IAccount)Session["Account"];

            if (Account == null)
            {
                Response.Redirect("/Pages/Login.aspx");
            }
            else
            {
                string currentPath = Page.AppRelativeVirtualPath.Substring(1);
                string[] splitted = currentPath.Split('/');

                if (splitted.Length > 3)
                {
                    string type = splitted[3];

                    switch (type)
                    {
                        case "Student": if (Account is Models.Student) return; break;
                        case "Mentor": if (Account is Mentor) return; break;
                        case "Parent": if (Account is Parent) return; break;
                    }

                    Response.Redirect("/Pages/Settings.aspx");
                }
            }
        }
    }
}
