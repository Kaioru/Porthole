using System;
using System.Collections.Generic;

namespace Porthole.Models
{
    public class Project
    {
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Poster { get; set; }
		public string URL { get; set; }

		public List<ProjectMember> Members { get; set; }
    }
}
