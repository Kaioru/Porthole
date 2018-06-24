using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using MoreLinq;
using Porthole.Models;
using Porthole.Utils;

namespace Porthole.Pages.Controls.Student
{
    public partial class CreateProject : System.Web.UI.Page
    {
        public Models.Student CurrentStudent { get; set; }
        public List<string> Eggs { get; set; } = new List<string>() { "cocodonkey", "geul", "kaioru", "deuxenigma", "polarcx" };
        public string Egg { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentStudent = (Models.Student)Session["Account"];

            if (!Page.IsPostBack)
            {
                Egg = Eggs[new Random().Next(Eggs.Count)];
                txtTitle.Attributes.Add("placeholder", "like " + Egg + " or something weird");

                lTitle.Text = string.Empty;
            }
        }

        public void txtTitle_TextChanged(Object sender, EventArgs e)
        {
            lTitle.Text = txtTitle.Text;
            figPoster.Attributes["data-initial"] = DisplayUtils.GetInitials(txtTitle.Text);
        }

        public void btnReset_Click(Object sender, EventArgs e)
        {
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            fuPoster.Dispose();
        }

        public void btnSubmit_Click(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.Project project = new Models.Project()
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    URL = txtURL.Text,
                    ProjectMembers = new List<ProjectMember>()
                };

                if (fuPoster.HasFile)
                {
                    try
                    {
                        string filename = Guid.NewGuid().ToString();
                        fuPoster.SaveAs(Server.MapPath("/Content/Posters/") + filename);
                        project.Poster = filename;
                    }
                    catch (Exception)
                    {

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
                context.Add(project);

                context.SaveChanges();
                Response.Redirect("/Pages/Controls/Student/UpdateProject.aspx");
            }
        }
    }
}
