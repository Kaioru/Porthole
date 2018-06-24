using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Porthole.Utils;

namespace Porthole.Models
{
    public class Parent : IAccount
    {
        [Key]
        [Column("ParentID")]
        public int ID { get; set; }
        [Column("ParentName")]
        public string Name { get; set; }

        [Column("EmailAddr")]
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public ICollection<ViewingRequest> Requests { get; set; }

        [NotMapped]
        public string Initials
        {
            get
            {
                return DisplayUtils.GetInitials(Name);
            }
        }
    }
}
