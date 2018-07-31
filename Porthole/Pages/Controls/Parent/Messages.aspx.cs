using Porthole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porthole.Pages.Controls.Parent
{
    public partial class Messages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string displayTitle;
            displayTitle = Request.QueryString["Title"];
            lblTitle.Text = displayTitle;

            string displayMessage;
            displayMessage = Request.QueryString["Text"];
            lblMessage.Text = displayMessage;
        }
            //Response.Redirect("/Pages/Parent/Messages.aspx"); // Redirects them back here 
    }
}