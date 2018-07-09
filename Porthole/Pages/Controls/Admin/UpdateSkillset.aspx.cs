using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Porthole.Models;

namespace Porthole.Pages.Controls.Admin
{
    public partial class UpdateSkillset : System.Web.UI.Page
    {
        public int id { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!Page.IsPostBack)
            {
            }
        }

        protected void btnUpdateSkillset_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                context.SkillSet.Single(ss => ss.ID == id).Name = txtNewSkillName.Text;
                context.SaveChanges();
                Response.Redirect("/Pages/Controls/Admin/ViewSkillset.aspx");
            }
        }
    }
}