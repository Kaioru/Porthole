using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages
{
    public partial class Student : System.Web.UI.Page
    {
		public Models.Student CurrentStudent { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			using (var context = new DatabaseContext()) {
				this.CurrentStudent = context.Student
					.Include(s => s.StudentSkillSets)
					.ThenInclude(ss => ss.SkillSet)
					.Include(s => s.ProjectMembers)
					.ThenInclude(pm => pm.Project)
					.Single(s => s.ID == Convert.ToInt32(Request.QueryString["id"]));
			}
		}
    }
}
