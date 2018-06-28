using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Porthole.Models;

namespace Porthole.Pages.Controls.Admin
{
    public partial class CreateSkillset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateSkill_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.SkillSet skillset = new Models.SkillSet()
                {
                    Name = txtSkillName.Text,
                };
                context.Add(skillset);
                context.SaveChanges();
                Response.Redirect("Pages/Controls/Admin/ViewSkillset.aspx");
            }
        }
    }
}