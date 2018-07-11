using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Porthole.Models;

namespace Porthole.Pages.Controls.Admin
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        
        public int id { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                if (fuLogo.HasFile)
                {
                    try
                    {
                        string filename = Guid.NewGuid().ToString();
                        fuLogo.SaveAs(Server.MapPath("/Content/Avatars/") + filename);
                        context.Student.Single(st => st.ID == id).Photo = filename;
                        context.SaveChanges();
                        lblResult.Text = "Profile updated!";
                    }
                    catch (Exception)
                    {

                    }
                }
                
            }
        }
    }
}