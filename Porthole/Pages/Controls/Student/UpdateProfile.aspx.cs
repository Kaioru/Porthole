using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Porthole.Models;

namespace Porthole.Pages.Controls.Student
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
		public Models.Student CurrentStudent { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			this.CurrentStudent = (Models.Student)Session["Account"];

			if (!Page.IsPostBack)
			{            
				txtDescription.Text = CurrentStudent.Description;
				txtAchievement.Text = CurrentStudent.Achievement;
				txtURL.Text = CurrentStudent.URL;
			}
		}

		public void btnSubmit_Click(Object sender, EventArgs e)
		{         
			using (var context = new DatabaseContext())
			{
				Models.Student student = context.Student
					.Single(s => s.ID == CurrentStudent.ID);

				student.Description = txtDescription.Text;
				student.Achievement = txtAchievement.Text;
				student.URL = txtURL.Text;
				context.SaveChanges();

				Session["Account"] = student;
				Response.Redirect("/Pages/Settings.aspx");
			}
		}
    }
}
