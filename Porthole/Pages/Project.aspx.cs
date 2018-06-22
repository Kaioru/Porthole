using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages
{
	public partial class Project : System.Web.UI.Page
    {
		public Models.Project CurrentProject { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
				this.CurrentProject = context.Project
					.Include(p => p.ProjectMembers)
                    .ThenInclude(pm => pm.Student)
                    .Single(s => s.ID == Convert.ToInt32(Request.QueryString["id"]));
            }
        }
    }
}
