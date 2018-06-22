using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole
{   
    public partial class Default : System.Web.UI.Page
    {
		public List<Student> Students { get; set; }

		protected void Page_Load(object sender, EventArgs e)
		{
			
		}
    }
}
