using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Student
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        public Models.Student CurrentStudent { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentStudent = (Models.Student)Session["Account"];

            if (!Page.IsPostBack)
            {
                Reset();
            }
        }

        public void btnReset_Click(Object sender, EventArgs e)
        {
            Reset();
            lblInfo.CssClass = "text-error";
            lblInfo.Text = "with the power of science, your details have been reset.";
        }

        public void Reset()
        {
            txtDescription.Text = CurrentStudent.Description;
            txtAchievement.Text = CurrentStudent.Achievement;
            txtURL.Text = CurrentStudent.URL;

            cblSkills.Items.Clear();
            using (var context = new DatabaseContext())
            {
                context.SkillSet
                       .Include(s => s.StudentSkillSets)
                       .ThenInclude(ss => ss.Student)
                       .ToList().ForEach(s =>
                {
                    cblSkills.Items.Add(new ListItem
                    {
                        Text = " " + s.Name,
                        Value = s.ID.ToString(),
                        Selected = s.StudentSkillSets.Any(ss => ss.Student.ID == CurrentStudent.ID)
                    });
                });
            }
        }

        public void btnSubmit_Click(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.Student student = context.Student
                    .Include(s => s.StudentSkillSets)
                    .ThenInclude(ss => ss.SkillSet)
                    .Single(s => s.ID == CurrentStudent.ID);

                student.Description = txtDescription.Text;
                student.Achievement = txtAchievement.Text;
                student.URL = txtURL.Text;

                student.StudentSkillSets.Clear();

                foreach (ListItem item in cblSkills.Items)
                {
                    if (item.Selected)
                    {
                        student.StudentSkillSets.Add(new StudentSkillSet
                        {
                            Student = student,
                            SkillSet = context.SkillSet
                                              .Single(s => s.ID == Convert.ToInt32(item.Value))
                        });
                    }
                }

                context.SaveChanges();

                CurrentStudent = student;
                Session["Account"] = student;
                Reset();
                lblInfo.CssClass = "text-success";
                lblInfo.Text = "beep beep boop, we've updated your profile!";
            }
        }
    }
}
