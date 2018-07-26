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

        public string Title { get; set; }
        public string Text { get; set; }

        [ForeignKey("ToID")]
        public Mentor Mentor { get; set; }
        [ForeignKey("FromID")]
        public Parent Parent { get; set; }

        [Column("DateTimePosted")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public ICollection<Reply> Replies { get; set; }
    }
}
