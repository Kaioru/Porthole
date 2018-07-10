using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Student
{
    public partial class ViewSuggestions : System.Web.UI.Page
    {
        public Models.Student CurrentStudent { get; set; }
        public List<Suggestion> NewSuggestions { get; set; }
        public List<Suggestion> OldSuggestions { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentStudent = (Models.Student)Session["Account"];

            if (Request.QueryString["ack"] != null)
            {
                int ack = Convert.ToInt32(Request.QueryString["ack"]);

                using (var context = new DatabaseContext())
                {
                    context.Suggestion
                           .Single(s => s.ID == ack)
                           .Status = "Y";
                    context.SaveChanges();
                }
            }

            using (var context = new DatabaseContext())
            {
                List<Suggestion> allSuggestions = context.Suggestion
                                                         .Include(s => s.Student)
                                                         .Include(s => s.Mentor)
                                                         .Where(s => s.Student.ID == CurrentStudent.ID)
                                                         .ToList();
                this.NewSuggestions = allSuggestions.FindAll(s => s.Status.Equals("N"));
                this.OldSuggestions = allSuggestions.FindAll(s => !NewSuggestions.Contains(s));

                this.NewSuggestions.Reverse();
                this.OldSuggestions.Reverse();
            }
        }
    }
}
