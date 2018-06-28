﻿using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Porthole.Pages.Layouts
{
    public partial class BreadCrumb : System.Web.UI.UserControl
    {
        public string CurrentPath { get; set; }
        public List<Crumb> Crumbs { get; set; } = new List<Crumb>();
        public List<Crumb> CurrentCrumbs { get; set; } = new List<Crumb>();

        public BreadCrumb()
        {
            Crumb home = new Crumb
            {
                Title = "home",
                Page = "/Pages/Home.aspx"
            };

            this.Crumbs.Add(new Crumb
            {
                Title = "students",
                Page = "/Pages/Students.aspx",
                Previous = home
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "projects",
                Page = "/Pages/Projects.aspx",
                Previous = home
            });

            this.Crumbs.Add(new Crumb
            {
                Title = "login",
                Page = "/Pages/Login.aspx",
                Previous = home
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "logout",
                Page = "/Pages/Logout.aspx",
                Previous = home
            });

            Crumb settings = new Crumb
            {
                Title = "settings",
                Page = "/Pages/Settings.aspx",
                Previous = home
            };

            this.Crumbs.Add(settings);

            this.Crumbs.Add(new Crumb
            {
                Title = "view skillset",
                Page = "/Pages/Controls/Admin/ViewSkillset.aspx",
                Previous = settings
            });

            this.Crumbs.Add(new Crumb
            {
                Title = "view student",
                Page = "/Pages/Controls/Admin/ViewStudent.aspx",
                Previous = settings
            });

            this.Crumbs.Add(new Crumb
            {
                Title = "update profile",
                Page = "/Pages/Controls/Student/UpdateProfile.aspx",
                Previous = settings
            });

            Crumb viewSkillsets = new Crumb
            {
                Title = "view skillsets",
                Page = "/Pages/Controls/Admin/ViewSkillset.aspx",
                Previous = settings
            };

            this.Crumbs.Add(viewSkillsets);
            this.Crumbs.Add(new Crumb
            {
                Title = "update skillset",
                Page = "/Pages/Controls/Admin/UpdateSkillset.aspx",
                Previous = viewSkillsets
            });

            this.Crumbs.Add(new Crumb
            {
                Title = "create skillset",
                Page = "/Pages/Controls/Admin/CreateSkillset.aspx",
                Previous = viewSkillsets
            });

            Crumb viewStudents = new Crumb
            {
                Title = "view students",
                Page = "/Pages/Controls/Admin/ViewStudents.aspx",
                Previous = settings
            };

            this.Crumbs.Add(viewStudents);
            this.Crumbs.Add(new Crumb
            {
                Title = "update profile",
                Page = "/Pages/Controls/Admin/UpdateProfile.aspx",
                Previous = viewStudents
            });

            Crumb updateProjects = new Crumb
            {
                Title = "update projects",
                Page = "/Pages/Controls/Student/UpdateProjects.aspx",
                Previous = settings
            };

            this.Crumbs.Add(updateProjects);
            this.Crumbs.Add(new Crumb
            {
                Title = "create project",
                Page = "/Pages/Controls/Student/CreateProject.aspx",
                Previous = updateProjects
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "edit project",
                Page = "/Pages/Controls/Student/UpdateProject.aspx",
                Previous = updateProjects
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "edit reflections",
                Page = "/Pages/Controls/Student/UpdateProjectReflections.aspx",
                Previous = updateProjects
            });

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CurrentPath = Page.AppRelativeVirtualPath.Substring(1).Split('?')[0];

            Crumb CurrentCrumb = Crumbs.Find(c => c.Page.Equals(CurrentPath));

            this.CurrentCrumbs.Add(CurrentCrumb);
            while (CurrentCrumb.Previous != null)
            {
                CurrentCrumb = CurrentCrumb.Previous;
                this.CurrentCrumbs.Add(CurrentCrumb);
            }

            this.CurrentCrumbs.Reverse();
        }

        public class Crumb
        {
            public string Title { get; set; }
            public string Page { get; set; }
            public Crumb Previous { get; set; }
        }
    }
}
