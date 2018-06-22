using System;
namespace Porthole.Models
{
    public class ProjectMember
    {
		public int StudentID { get; set; }
		public Student Student { get; set; }
		public int ProjectID { get; set; }
		public Project Project { get; set; }

		public string Role { get; set; }
		public string Reflection { get; set; }
    }
}
