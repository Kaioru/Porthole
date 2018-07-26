using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Admin
{
    public partial class ViewRequest : System.Web.UI.Page
    {
        public List<ViewingRequest> ViewingRequests { get; set; }
        public Models.ViewingRequest viewrequest { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string check = Request.QueryString["check"];
            string cross = Request.QueryString["cross"];
            if (!Page.IsPostBack)
            {
                using (var context = new DatabaseContext())
                {
                    ViewingRequests = context.ViewingRequest
                        .Include(v => v.Parent)
                        .Where(v => v.Status.Equals("P"))
                        .ToList();
                }
            }
            if (check != null)
            {
                if (check == "true")
                {
                    using (var context = new DatabaseContext())
                    {
                        context.ViewingRequest.Single(ss => ss.ID == id).Status = "A";
                        context.SaveChanges();
                    }
                    Response.Redirect("ViewRequest.aspx");
                }
            }
            
            if (cross != null)
            {
                if (cross == "true")
                {
                    using (var context = new DatabaseContext())
                    {
                        context.ViewingRequest.Single(ss => ss.ID == id).Status = "R";
                        context.SaveChanges();   
                    }
                    Response.Redirect("ViewRequest.aspx");
                }
            }
        }
    }
}