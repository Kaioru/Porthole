using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Mentor
{

    public partial class ViewMessage : System.Web.UI.Page
    {
        public Models.Mentor CurrentMentor { get; set; }
        public Models.Message CurrentMessage { get; set; }
        public List<Models.Reply> Replies { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            this.CurrentMentor = (Models.Mentor)Session["Account"];
            using (var context = new DatabaseContext())
            {
                CurrentMessage = context.Message
                                        .Include(m => m.Mentor)
                                        .Include(m => m.Parent)
                                        .Include(m => m.Replies)
                                        .Single(p => p.ID == Convert.ToInt32(Request.QueryString["id"]));
                Replies = CurrentMessage.Replies.ToList();
            }
        }

        public void btnSend_Click(Object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (var context = new DatabaseContext())
                {
                    Models.Reply reply = new Models.Reply
                    {
                        Text = txtInput.Text,
                        Message = context.Message
                                         .Single(m => m.ID == CurrentMessage.ID),
                        Mentor = context.Mentor
                                        .Single(m => m.ID == CurrentMentor.ID),
                    };

                    context.Add(reply);
                    context.SaveChanges();
                }

                txtInput.Text = String.Empty;
                Reset();
            }
        }
    }
}
