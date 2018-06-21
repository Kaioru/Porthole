using System;
namespace Porthole.Models
{
    public class ProjectMember
    {
		public Project Project { get; set; }
		public Student Student { get; set; }

		public string Role { get; set; }
		public string Reflection { get; set; }
    }
}
