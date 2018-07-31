using Porthole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porthole.Pages.Controls.Parent
{
    public partial class Selection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                context.Mentor
                    .ToList()
                    .ForEach(m => {
                        ddl_Mentor.Items.Add(m.Name); // Adding the Mentor's name to a DropDownList for the parent to choose
                    });
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Message messages = new Message();

                messages.Title = txtTitle.Text; // Message Title

                messages.Text = txtMessage.Text; // Message itself

                messages.Parent = context.Parent.Single(p => p.ID == (Session["Account"] as Models.Parent).ID); // Checks to see if you are a parent (FromID)

                messages.Mentor = context.Mentor.Single(m => m.Name.Equals(ddl_Mentor.SelectedValue) ); // Sends to the mentor (ToID)

                context.Add(messages); // INSERTS into the Database

                context.SaveChanges();
            }
            Response.Redirect("Messages.aspx?Title= " + txtTitle.Text + "Messages.aspx?Message= " + txtMessage.Text); // Redirect
        }
    }
}