using Porthole.Models;
using static Porthole.Models.Reply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porthole.Pages.Controls.Parent
{
    public partial class Reply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                context.Message.ToList().ForEach(r =>
                {
                    ddl_Message.Items.Add(r.Text); // Adding the meesages into this DropDownList for the parent to reply to
                });

                context.Mentor
                    .ToList()
                    .ForEach(m => {
                        ddl_Mentor.Items.Add(m.Name); // Adding the Mentor's name to a DropDownList for the parent to choose
                    });
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Models.Reply Replies = new Models.Reply();

                Replies.Text = txtReply.Text; // Reply itself

                Replies.Parent = context.Parent.Single(p => p.ID == (Session["Account"]as Models.Parent).ID); // Checks to see if you are a parent (FromID)

                Replies.Mentor = context.Mentor.Single(m => m.Name.Equals(ddl_Mentor.SelectedValue)); // To know the mentor

                Replies.Message = context.Message.Single(n => n.Text.Equals(ddl_Message.SelectedValue)); // For the message they reply to

                context.Add(Replies); // INSERT into the database

                context.SaveChanges();
            }
            Response.Redirect("Messages.aspx?Title= " + txtReply.Text);
        }
    }
}