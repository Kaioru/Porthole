using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Student
{
    public partial class UpdateProjectReflections : System.Web.UI.Page
    {
        public Models.Student CurrentStudent { get; set; }
        public Models.Project CurrentProject { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentStudent = (Models.Student)Session["Account"];
            using (var context = new DatabaseContext())
            {
                CurrentProject = context.Project
                                        .Include(p => p.ProjectMembers)
                                        .ThenInclude(m => m.Student)
                                        .Single(p => p.ID == Convert.ToInt32(Request.QueryString["id"]));
            }

            if (!Page.IsPostBack)
            {
                Reset();
            }
        }

        public void Reset()
        {
            txtReflections.Text = CurrentProject.ProjectMembers.Single(m => m.Student.ID == CurrentStudent.ID).Reflection;
        }

        public void btnReset_Click(Object sender, EventArgs e)
        {
            Reset();
            lblInfo.CssClass = "text-error";
            lblInfo.Text = "bada-bing bada-boong, your details have been reset.";
        }

        public void btnSubmit_Click(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.Project project = context.Project
                    .Include(p => p.ProjectMembers)
                    .ThenInclude(m => m.Student)
                    .Single(s => s.ID == CurrentProject.ID);

                project.ProjectMembers.Single(m => m.Student.ID == CurrentStudent.ID).Reflection = txtReflections.Text;
                context.SaveChanges();

                CurrentProject = project;
                Reset();
                lblInfo.CssClass = "text-success";
                lblInfo.Text = "huzzah, we've updated your project!";
            }
        }
    }
}
