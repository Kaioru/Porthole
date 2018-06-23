using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Student
{
    public partial class UpdateProjects : System.Web.UI.Page
    {
        public List<Models.Project> OwnedProjects { get; set; }
        public List<Models.Project> RelatedProjects { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Models.Student student = (Models.Student)Session["Account"];

            using (var context = new DatabaseContext()) {
                List<Models.Project> allProjects = context.Project
                    .Include(p => p.ProjectMembers)
                    .ThenInclude(m => m.Student)
                    .Where(p => p.ProjectMembers
                           .Any(m => m.Student.ID == student.ID))
                    .ToList();
                this.RelatedProjects = allProjects.FindAll(p => p.ProjectMembers.Any(m => m.Student.ID == student.ID && !m.Role.Equals("Leader")));
                this.OwnedProjects = allProjects.FindAll(p => p.ProjectMembers.Any(m => m.Student.ID == student.ID && m.Role.Equals("Leader")));
            }
        }
    }
}
