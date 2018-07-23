using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Mentor
{
    public partial class ViewSuggestions : System.Web.UI.Page
    {
        public Models.Mentor CurrentMentor { get; set; }
        public List<Models.Student> Mentees { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CurrentMentor = (Models.Mentor)Session["Account"];

            using (var context = new DatabaseContext())
            {
                this.Mentees = context.Student
                    .Include(s => s.Mentor)
                    .Where(s => s.Mentor.ID == CurrentMentor.ID)
                    .ToList();
            }
        }
    }
}
