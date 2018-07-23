using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
    public class Suggestion
    {
        [Key]
        [Column("SuggestionID")]
        public int ID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public Mentor Mentor { get; set; }
        public Student Student { get; set; }
    }
}
