using System;
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

            Crumb login = new Crumb
            {
                Title = "login",
                Page = "/Pages/Login.aspx",
                Previous = home
            };

            this.Crumbs.Add(login);
            this.Crumbs.Add(new Crumb
            {
                Title = "logout",
                Page = "/Pages/Logout.aspx",
                Previous = home
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "register",
                Page = "/Pages/Register.aspx",
                Previous = login
            });

            Crumb settings = new Crumb
            {
                Title = "settings",
                Page = "/Pages/Settings.aspx",
                Previous = home
            };

            this.Crumbs.Add(settings);

            this.Crumbs.Add(new Crumb()
            {
                Title = "publicize student",
                Page = "/Pages/Controls/Mentor/PublicizeStudent.aspx",
                Previous = settings
            });

            Crumb viewSuggestions = (new Crumb()
            {
                Title = "view suggestions",
                Page = "/Pages/Controls/Mentor/ViewSuggestions.aspx",
                Previous = settings
            });

            this.Crumbs.Add(viewSuggestions);
            this.Crumbs.Add(new Crumb()
            {
                Title = "update suggestions",
                Page = "/Pages/Controls/Mentor/UpdateSuggestions.aspx",
                Previous = viewSuggestions
            });

            Crumb viewMessages = (new Crumb()
            {
                Title = "view messages",
                Page = "/Pages/Controls/Mentor/ViewMessages.aspx",
                Previous = settings
            });

            this.Crumbs.Add(viewMessages);
            this.Crumbs.Add(new Crumb()
            {
                Title = "view message",
                Page = "/Pages/Controls/Mentor/ViewMessage.aspx",
                Previous = viewMessages
            });

            this.Crumbs.Add(new Crumb()
            {
                Title = "search students",
                Page = "/Pages/Controls/Mentor/SearchStudents.aspx",
                Previous = settings
            });

            this.Crumbs.Add(new Crumb()
            {
                Title = "change password",
                Page = "/Pages/Controls/Mentor/ChangePassword.aspx",
                Previous = settings
            });

            this.Crumbs.Add(new Crumb
            {
                Title = "view skillset",
                Page = "/Pages/Controls/Admin/ViewSkillset.aspx",
                Previous = settings
            });

            this.Crumbs.Add(new Crumb
            {
                Title = "create account",
                Page = "/Pages/Controls/Admin/CreateAccount.aspx",
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

            Crumb viewStudent = new Crumb
            {
                Title = "view students",
                Page = "/Pages/Controls/Admin/ViewStudent.aspx",
                Previous = settings
            };

            this.Crumbs.Add(viewStudent);
            this.Crumbs.Add(new Crumb
            {
                Title = "update profile",
                Page = "/Pages/Controls/Admin/UpdateProfile.aspx",
                Previous = viewStudent
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
            this.Crumbs.Add(new Crumb
            {
                Title = "view suggestions",
                Page = "/Pages/Controls/Student/ViewSuggestions.aspx",
                Previous = settings
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "send request",
                Page = "/Pages/Controls/Parent/SendRequest.aspx",
                Previous = settings
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "send message",
                Page = "/Pages/Controls/Parent/Selection.aspx",
                Previous = settings
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "send message",
                Page = "/Pages/Controls/Parent/Messages.aspx",
                Previous = settings
            });
            this.Crumbs.Add(new Crumb
            {
                Title = "reply message",
                Page = "/Pages/Controls/Parent/Reply.aspx",
                Previous = settings
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
