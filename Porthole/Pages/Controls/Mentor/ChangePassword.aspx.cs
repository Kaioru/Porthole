using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Porthole.Models;

namespace Porthole.Pages.Controls.Mentor
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        public Models.Mentor CurrentMentor { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CurrentMentor = (Models.Mentor)Session["Account"];
        }

        protected void PasswordValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = txtNewPassword.Text.Equals(txtNewPassword2.Text);
        }

        protected void Password2Validate(object source, ServerValidateEventArgs args)
        {
            using (var context = new DatabaseContext())
            {
                Models.Mentor mentor = context.Mentor
                                              .Single(s => s.ID == CurrentMentor.ID);

                args.IsValid = mentor.Password.Equals(txtPassword.Text);
            }
        }

        public void btnSubmit_Click(Object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (var context = new DatabaseContext())
                {
                    Models.Mentor mentor = context.Mentor
                                           .Single(s => s.ID == CurrentMentor.ID);

                    mentor.Password = txtNewPassword.Text;
                    context.SaveChanges();

                    lblInfo.CssClass = "text-success";
                    lblInfo.Text = "levi-o-sa! your password has now changed.";
                }
            }
        }
    }
}
