using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Porthole.Utils;

namespace Porthole.Models
{
    public class Project
    {
        [Key]
        [Column("ProjectID")]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Column("ProjectPoster")]
        public string Poster { get; set; }
        [Column("ProjectURL")]
        public string URL { get; set; }

        public ICollection<ProjectMember> ProjectMembers { get; set; }

        [NotMapped]
        public string Initials
        {
            get
            {
                return DisplayUtils.GetInitials(Title);
            }
        }

        [NotMapped]
        public string ShortDescription
        {
            get
            {
                return DisplayUtils.TruncateAtWord(Description);
            }
        }
    }
}
