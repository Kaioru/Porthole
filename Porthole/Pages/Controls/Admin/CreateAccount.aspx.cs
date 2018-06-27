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
            if (!IsPostBack)
            {
                using (var context = new  DatabaseContext())
                {
                    List<Mentor> mentorList = context.Mentor.ToList();

                    foreach (Mentor m in mentorList)
                    {
                        ddlMentor.Items.Add(m.Name);
                    }
                }
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {

            using (var context = new DatabaseContext())
            {
                if (rbMentor.Checked)
                {
                    Mentor mentor = new Mentor()
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
                        Mentor = context.Mentor.Single(m => m.Name.Equals(ddlMentor.SelectedValue))
                    };
                    context.Add(student);
                }
                

                context.SaveChanges();
                Response.Redirect("/Pages/Settings.aspx");
            }

        }

        protected void rbMentor_CheckedChanged(object sender, EventArgs e)
        {
            lblMentor.Visible = !rbMentor.Checked;
            ddlMentor.Visible = !rbMentor.Checked;
        }

        protected void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            lblMentor.Visible = !rbMentor.Checked;
            ddlMentor.Visible = !rbMentor.Checked;
        }
    }
}