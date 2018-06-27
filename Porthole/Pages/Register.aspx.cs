using System;
using System.Web;
using System.Web.UI;
using Porthole.Models;

namespace Porthole.Pages
{
    public partial class Register : System.Web.UI.Page
    {
        public void btnRegister_Click(Object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                context.Add(new Parent
                {
                    Name = txtName.Text,
                    EmailAddress = txtEmail.Text,
                    Password = txtPassword.Text
                });
                context.SaveChanges();
            }

            Response.Redirect("Login.aspx");
        }
    }
}
