using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
    public interface IAccount
    {
        string Name { get; set; }
        string EmailAddress { get; set; }
        string Password { get; set; }

        string Initials { get; }
    }
}
