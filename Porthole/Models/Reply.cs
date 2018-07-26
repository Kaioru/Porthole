using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
    public class Reply
    {
        [Key]
        [Column("ReplyID")]
        public int ID { get; set; }

        public string Text { get; set; }

        public Message Message { get; set; }
        public Mentor Mentor { get; set; }
        public Parent Parent { get; set; }


        [Column("DateTimePosted")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
    }
}
