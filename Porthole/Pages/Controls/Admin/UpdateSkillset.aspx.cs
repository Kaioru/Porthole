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
        public List<SkillSet> skillSets { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (var context = new DatabaseContext())
                {
                    skillSets = context.SkillSet.ToList();
                }
            }
        }

        protected void btnUpdateSkillset_Click(object sender, EventArgs e)
        {

        }
    }
}