using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Porthole.Models;

namespace Porthole.Pages
{   
    public partial class Login : System.Web.UI.Page
    {
		public void btnLogin_Click(Object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			string password = txtPassword.Text;

			using (var context = new DatabaseContext()) {
				List<IAccount> accounts = new List<IAccount>();

				accounts.AddRange(context.Student.ToList());
				accounts.AddRange(context.Mentor.ToList());
				accounts.AddRange(context.Parent.ToList());

				IAccount account = accounts.Find(a => a.EmailAddress.Equals(email) && a.Password.Equals(password));

				if (account != null) {
					Session["Account"] = account;
                    Response.Redirect("Students.aspx");
				} else {
					lblError.Text = "wrong email or password! check your privileges again, sir.";
				}
			}
		}
    }
}
