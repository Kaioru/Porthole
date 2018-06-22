using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole
{   
    public partial class Projects : System.Web.UI.Page
    {
		public List<Models.Project> PublicProjects { get; set; } = new List<Models.Project>();

		protected void Page_Load(object sender, EventArgs e)
		{
			using (var context = new DatabaseContext())
			{
				this.PublicProjects = context.Project
					.ToList();
			}
		}
    }
}
