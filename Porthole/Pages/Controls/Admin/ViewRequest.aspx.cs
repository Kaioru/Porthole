using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Porthole.Models;

namespace Porthole.Pages.Controls.Admin
{
    public partial class ViewRequest : System.Web.UI.Page
    {
        public List<ViewingRequest> ViewingRequests { get; set; }
        public Models.ViewingRequest viewrequest { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (var context = new DatabaseContext())
                {
                    ViewingRequests = context.ViewingRequest.ToList();
                }
            }
        }
    }
}