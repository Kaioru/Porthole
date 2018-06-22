using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages
{   
    public partial class Students : System.Web.UI.Page
    {
		public List<Models.Student> Children { get; set; } = new List<Models.Student>();
		public List<Models.Student> PublicStudents { get; set; } = new List<Models.Student>();

		protected void Page_Load(object sender, EventArgs e)
		{
			using (var context = new DatabaseContext()) {
				IAccount account = (IAccount)Session["Account"];

				if (account != null) {
					if (account is Parent) {
						Parent parent = context.Parent
						                       .Include(p => p.Requests)
						                       .ThenInclude(r => r.Student)
						                       .Single(p => p.ID.Equals(((Parent)account).ID));

						this.Children = parent.Requests
							  .Where(r => r.Status.Equals("A"))
							  .Select(r => r.Student)
							  .ToList();
					}
				}

				this.PublicStudents = context.Student
					.Where(s => s.Status.Equals("Y"))
					.ToList();
			}
		}
    }
}
