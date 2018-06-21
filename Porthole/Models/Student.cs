using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
    public partial class Student
    {
		[Column("StudentID")]
		public int ID { get; set; }      
		public string Name { get; set; }
		public string Course { get; set; }
		public string Photo { get; set; }
		public string Description { get; set; }
		public string Achievement { get; set; }
		[Column("ExternalLink")]
		public string URL { get; set; }
		[Column("EmailAddr")]
		public string EmailAddress { get; set; }
		public string Password { get; set; }
		public string Status { get; set; }
    }
}
