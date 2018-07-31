using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porthole.Pages.Controls.Parent
{
    public partial class ViewChat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblParentmessage.Text = Request.QueryString[""];
            lblDateTime.Text = Request.QueryString[""];
        }
    }
}