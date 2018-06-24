using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Student
{
    public partial class UpdateProject : System.Web.UI.Page
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
            txtTitle.Text = CurrentProject.Title;
            txtDescription.Text = CurrentProject.Description;
            txtReflections.Text = CurrentProject.ProjectMembers.Single(m => m.Student.ID == CurrentStudent.ID).Reflection;
            fuPoster.Dispose();

            cblCollaborators.Items.Clear();
            using (var context = new DatabaseContext())
            {
                context.Student.ToList().ForEach(s =>
                {
                    if (s.ID != CurrentProject.ProjectMembers.Single(m => m.Role.Equals("Leader")).Student.ID)
                    {
                        cblCollaborators.Items.Add(new ListItem
                        {
                            Text = " " + s.Name,
                            Value = s.ID.ToString(),
                            Selected = CurrentProject.ProjectMembers.Any(m => m.Student.ID == s.ID)
                        });
                    }
                });
            }

            lTitle.Text = txtTitle.Text;
        }

        public void txtTitle_TextChanged(Object sender, EventArgs e)
        {
            lTitle.Text = txtTitle.Text;
        }

        public void btnReset_Click(Object sender, EventArgs e)
        {
            Reset();
            lblInfo.CssClass = "text-error";
            lblInfo.Text = "bada-bing bada-boong, your details have been reset.";
        }

        public void btnDelete_Click(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.Project project = context.Project
                    .Include(p => p.ProjectMembers)
                    .Single(s => s.ID == CurrentProject.ID);

                project.ProjectMembers.Clear();
                context.Remove(project);
                context.SaveChanges();
                Response.Redirect("/Pages/Settings.aspx");
            }
        }

        public void btnSubmit_Click(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.Project project = context.Project
                    .Include(p => p.ProjectMembers)
                    .ThenInclude(m => m.Student)
                    .Single(s => s.ID == CurrentProject.ID);

                project.Title = txtTitle.Text;
                project.Description = txtDescription.Text;

                if (fuPoster.HasFile)
                {
                    try
                    {
                        string filename = Path.GetFileName(fuPoster.FileName);

                        fuPoster.SaveAs(Server.MapPath("/Content/Posters/") + filename);
                        project.Poster = filename;
                    }
                    catch (Exception)
                    {

                    }
                }

                project.ProjectMembers.Clear();
                foreach (ListItem item in cblCollaborators.Items)
                {
                    if (item.Selected)
                    {
                        project.ProjectMembers.Add(new ProjectMember()
                        {
                            Project = project,
                            Student = context.Student
                                             .Single(s => s.ID == Convert.ToInt32(item.Value)),
                            Role = "Member"
                        });
                    }
                }
                project.ProjectMembers.Add(new ProjectMember()
                {
                    Project = project,
                    Student = context.Student
                                     .Single(s => s.ID == CurrentStudent.ID),
                    Role = "Leader",
                    Reflection = txtReflections.Text
                });

                context.SaveChanges();

                CurrentProject = project;
                Reset();
                lblInfo.CssClass = "text-success";
                lblInfo.Text = "huzzah, we've updated your project!";
            }
        }
    }
}
