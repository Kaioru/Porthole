using System;
using System.Web.UI;

namespace Porthole.Pages.Layouts
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
        }
    }
}
