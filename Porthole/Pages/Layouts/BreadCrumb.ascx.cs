using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Porthole.Pages.Layouts
{   
    public partial class BreadCrumb : System.Web.UI.UserControl
    {
		public string CurrentPath { get; set; }
		public List<Crumb> Crumbs { get; set; } = new List<Crumb>();
		public List<Crumb> CurrentCrumbs { get; set; } = new List<Crumb>();

		public BreadCrumb() {
			Crumb home = new Crumb
			{
				Title = "home",
				Page = "/Pages/Students.aspx"
			};

			Crumb settings = new Crumb
			{
				Title = "settings",
				Page = "/Pages/Settings.aspx",
				Previous = home
			};

			this.Crumbs.Add(new Crumb {
				Title = "update profile",
                Page = "/Pages/Controls/Student/UpdateProfile.aspx",
				Previous = settings
			});

            Crumb updateProjects = new Crumb
            {
                Title = "update projects",
                Page = "/Pages/Controls/Student/UpdateProjects.aspx",
                Previous = settings
            };

            this.Crumbs.Add(updateProjects);
            this.Crumbs.Add(new Crumb {
                Title = "create project",
                Page = "/Pages/Controls/Student/CreateProject.aspx",
                Previous = updateProjects
            });
		}

		protected void Page_Load(object sender, EventArgs e)
        {
			this.CurrentPath = Page.AppRelativeVirtualPath.Substring(1);

			Crumb CurrentCrumb = Crumbs.Find(c => c.Page.Equals(CurrentPath));

			this.CurrentCrumbs.Add(CurrentCrumb);
			while (CurrentCrumb.Previous != null) {
				CurrentCrumb = CurrentCrumb.Previous;
				this.CurrentCrumbs.Add(CurrentCrumb);
			}

			this.CurrentCrumbs.Reverse();
		}

		public class Crumb {
			public string Title { get; set; }
			public string Page { get; set; }
			public Crumb Previous { get; set; }
		}
    }
}
