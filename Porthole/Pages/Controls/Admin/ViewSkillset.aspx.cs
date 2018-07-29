using Porthole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porthole.Pages.Controls.Admin
{
    public partial class ViewSkillset : System.Web.UI.Page
    {
        public bool IsSearch { get; set; } = false;
        public List<SkillSet> SearchResults;
        public List<SkillSet> SkillSets { get; set; }
        public Models.SkillSet skillset { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                IsSearch = Request.QueryString["search"] != null;

                if (IsSearch)
                {
                    using (var context = new DatabaseContext())
                    {
                        string name = Request.QueryString["name"].ToLower();

                        var query = context.SkillSet.Where(s => s.Name.ToLower().Contains(name));

                        SearchResults = query.ToList();
                    }
                }

                else
                {
                    using (var context = new DatabaseContext())
                    {
                        SkillSets = context.SkillSet.ToList();
                        
                    }
                }
            }
        }

        protected void btnSearchBar_Click(object sender, EventArgs e)
        {
            string queries = "";

            queries += "search=True&";
            queries += "name=" + Server.UrlEncode(txtSearch.Text);

            Response.Redirect("/Pages/Controls/Admin/ViewSkillset.aspx?" + queries);
        }
    }
}