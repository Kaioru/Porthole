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
        public Models.Student CurrentStudent { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentStudent = (Models.Student)Session["Account"];
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
                        CurrentStudent.Photo = filename;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}