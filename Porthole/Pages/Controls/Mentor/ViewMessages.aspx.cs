using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Mentor
{

    public partial class ViewMessages : System.Web.UI.Page
    {
        public Models.Mentor CurrentMentor { get; set; }
        public List<Models.Message> Messages { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CurrentMentor = (Models.Mentor)Session["Account"];

            using (var context = new DatabaseContext())
            {
                this.Messages = context.Message
                    .Include(m => m.Mentor)
                    .Include(m => m.Parent)
                    .Where(m => m.Mentor.ID == CurrentMentor.ID)
                    .ToList();
            }
        }
    }
}
