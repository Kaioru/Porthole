using System;

namespace Porthole.Pages
{
    public partial class Logout : System.Web.UI.Page
    {
        public void btnLogout_Click(Object sender, EventArgs e)
        {
            Session["Account"] = null;
            Response.Redirect("Students.aspx");
        }
    }
}
