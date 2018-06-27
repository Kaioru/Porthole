using System;
namespace Porthole.Models
{
	public class StudentSkillSet
	{
		public int StudentID { get; set; }
		public Student Student { get; set; }
		public int SkillSetID { get; set; }
		public SkillSet SkillSet { get; set; }
	}
}
