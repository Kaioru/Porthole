using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
    public class Student
    {
		[Key]
		[Column("StudentID")]
		public int ID { get; set; }      
		public string Name { get; set; }
		public string Course { get; set; }
		public string Photo { get; set; }
		public string Description { get; set; }
		public string Achievement { get; set; }
		[Column("ExternalLink")]
		public string URL { get; set; }
		public string Status { get; set; }
		[Column("EmailAddr")]
		public string EmailAddress { get; set; }
		public string Password { get; set; }
      
		public Mentor Mentor { get; set; }
		public ICollection<StudentSkillSet> StudentSkillSets { get; set; }
		public ICollection<ProjectMember> ProjectMembers { get; set; }
		public ICollection<Suggestion> Suggestions { get; set; }
		public ICollection<ViewingRequest> Requests { get; set; }
    }
}
