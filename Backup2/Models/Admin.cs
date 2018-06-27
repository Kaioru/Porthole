using System;
using Porthole.Utils;

namespace Porthole.Models
{
    public class Admin : IAccount
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public string Initials
        {
            get
            {
                return DisplayUtils.GetInitials(Name);
            }
        }
    }
}
