using Porthole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Porthole.Pages.Controls.Parent
{
    public partial class SendRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e) // Send Button for SendRequest.aspx
        {
            using (var context = new DatabaseContext()) // Our version using database required for any SQL shit
            {
                ViewingRequest request = new ViewingRequest();
           
                request.StudentName = StudName.Text; // Name of Student
                
                request.Parent = context.Parent.Single(p => p.ID == (Session["Account"] as Models.Parent).ID);
                
                /*This is code uses the Logged in Parents ID to search the Database to retrieve the records
                 and set them as the Parent who is requesting Access in SendRequest.aspx.*/ // The simpler version of the SQL INSERT INTO thing.

                request.Status = "P"; // This line will set a default value for Statu tab as "P" for Pending

                context.Add(request); 

                context.SaveChanges(); // This line saves and adds the data into the ViewingRequest table.


            }
            Response.Redirect("/Pages/Settings.aspx");
        }
    }
}