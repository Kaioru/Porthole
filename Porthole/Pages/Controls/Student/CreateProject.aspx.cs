using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

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

            if (!Page.IsPostBack) {
                Egg = Eggs[new Random().Next(Eggs.Count)];
                txtTitle.Attributes.Add("placeholder", "like " + Egg + " or something weird");

                lTitle.Text = string.Empty;
            }
        }

        public void txtTitle_TextChanged(Object sender, EventArgs e)
        {
            lTitle.Text = txtTitle.Text;
        }

        public void btnReset_Click(Object sender, EventArgs e)
        {
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        public void btnSubmit_Click(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.Project project = new Models.Project()
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    ProjectMembers = new List<ProjectMember>()
                };

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
                Response.Redirect("/Pages/Settings.aspx");
            }
        }
    }
}
