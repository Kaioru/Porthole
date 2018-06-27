using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
    public class ViewingRequest
    {
		[Key]
        [Column("ViewingRequestID")]
        public int ID { get; set; }
		public string StudentName { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }

		public Parent Parent { get; set; }
		public Student Student { get; set; }
    }
}
