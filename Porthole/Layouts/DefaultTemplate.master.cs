using System;
using System.Web;
using System.Web.UI;
using Porthole.Models;

namespace Porthole.Layouts
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
