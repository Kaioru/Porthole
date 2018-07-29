using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Mentor
{
    public partial class UpdateSuggestions : System.Web.UI.Page
    {
        public Models.Mentor CurrentMentor { get; set; }
        public Models.Student CurrentStudent { get; set; }
        public List<Models.Suggestion> Suggestions { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            this.CurrentMentor = (Models.Mentor)Session["Account"];
            using (var context = new DatabaseContext())
            {
                CurrentStudent = context.Student
                                        .Include(s => s.Mentor)
                                        .Single(p => p.ID == Convert.ToInt32(Request.QueryString["id"]));
                Suggestions = context.Suggestion
                                     .Include(s => s.Mentor)
                                     .Include(s => s.Student)
                                     .Where(s => s.Mentor.ID == CurrentMentor.ID && s.Student.ID == CurrentStudent.ID)
                                     .ToList();
            }
        }

        public void btnSend_Click(Object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (var context = new DatabaseContext())
                {
                    Models.Suggestion suggestion = new Models.Suggestion
                    {
                        Description = txtInput.Text,
                        Status = "N",
                        Mentor = context.Mentor
                                        .Single(m => m.ID == CurrentMentor.ID),
                        Student = context.Student
                                         .Single(m => m.ID == CurrentStudent.ID),
                    };

                    var student = context.Student.Single(m => m.ID == CurrentStudent.ID);

                    student.Status = "N";
                    context.Update(student);

                    context.Add(suggestion);
                    context.SaveChanges();
                }

                txtInput.Text = String.Empty;
                Reset();
            }
        }
    }
}
