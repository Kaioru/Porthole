using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Mentor
{
    public partial class PublicizeStudent : System.Web.UI.Page
    {
        public Models.Mentor CurrentMentor { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CurrentMentor = (Models.Mentor)Session["Account"];

            if (!Page.IsPostBack)
            {
                using (var context = new DatabaseContext())
                {
                    context.Student
                           .Include(s => s.Mentor)
                           .ToList().ForEach(s =>
                    {
                        if (s.Mentor.ID == CurrentMentor.ID)
                        {
                            cblStudents.Items.Add(new ListItem
                            {
                                Text = " " + s.Name,
                                Value = s.ID.ToString(),
                                Selected = s.Status.Equals("Y")
                            });
                        }
                    });
                }
            }
        }

        public void cblStudents_SelectedIndexChanged(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                foreach (ListItem item in cblStudents.Items)
                {
                    Models.Student student = context.Student
                        .Single(s => s.ID == Convert.ToInt32(item.Value));

                    student.Status = item.Selected ? "Y" : "N";
                }

                context.SaveChanges();
            }
        }
    }
}
