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
        public List<SkillSet> SkillSets { get; set; }
        public Models.SkillSet skillset { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (var context = new DatabaseContext())
                {
                    SkillSets = context.SkillSet.ToList();
                }
            }
        }
    }
}