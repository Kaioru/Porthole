using System;
using Porthole.Models;

namespace Porthole.Pages.Layouts
{
    public partial class DefaultTemplate : System.Web.UI.MasterPage
    {
        public IAccount Account { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Account = (IAccount)Session["Account"];
        }
    }
}
