using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Porthole.Utils;

namespace Porthole.Models
{
    public class SkillSet
    {
        [Key]
        [Column("SkillSetID")]
        public int ID { get; set; }
        [Column("SkillSetName")]
        public string Name { get; set; }

        public ICollection<StudentSkillSet> StudentSkillSets { get; set; }

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
