using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
    public class Message
    {
        [Key]
        [Column("MessageID")]
        public int ID { get; set; }

        public string Title { get; set; } // Advance #1
        public string Text { get; set; } // Advance #1

        [ForeignKey("ToID")]
        public Mentor Mentor { get; set; } // Advnace #1
        [ForeignKey("FromID")]
        public Parent Parent { get; set; }// Advacne #1

        [Column("DateTimePosted")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] // Automatically created
        public DateTime DateCreated { get; set; }

        public ICollection<Reply> Replies { get; set; } // To use when responding to mentor's reply
    }
}
