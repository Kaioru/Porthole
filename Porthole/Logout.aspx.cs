using System;
using System.Web;
using System.Web.UI;

namespace Porthole
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
