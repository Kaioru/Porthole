using Porthole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porthole.Pages.Controls.Admin
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rblAccountType.SelectedIndex = 0;
            if (!IsPostBack)
            {
                rblAccountType.Items.Add("Mentor");
                rblAccountType.Items.Add("Student");
                using (var context = new DatabaseContext())
                {
                    List<Models.Mentor> mentorList = context.Mentor.ToList();

                    foreach (Models.Mentor m in mentorList)
                    {
                        ddlMentor.Items.Add(m.Name);
                    }
                }
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string type = rblAccountType.SelectedValue;
            using (var context = new DatabaseContext())
            {
                if (type == "Mentor")
                {
                    Models.Mentor mentor = new Models.Mentor()
                    {
                        Name = txtName.Text,
                        EmailAddress = txtEmail.Text,
                        Password = txtPassword.Text
                    };
                    context.Add(mentor);
                }

                else
                {
                    Models.Student student = new Models.Student()
                    {
                        Name = txtName.Text,
                        EmailAddress = txtEmail.Text,
                        Password = txtPassword.Text,
                        Course = txtCourse.Text,
                        Status = "N",

                        Mentor = context.Mentor.Single(m => m.Name.Equals(ddlMentor.SelectedValue))
                    };
                    context.Add(student);
                }


                context.SaveChanges();
                Response.Redirect("/Pages/Settings.aspx");
            }

        }

        protected void rblAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblAccountType.SelectedValue == "Mentor")
            {
                lblMentor.Visible = false;
                ddlMentor.Visible = false;
            }
            else
            {
                lblMentor.Visible = true;
                ddlMentor.Visible = true;
            }
        }
    }
}