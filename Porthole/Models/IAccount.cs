using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
	public interface IAccount
    {
        string EmailAddress { get; set; }
        string Password { get; set; }
    }
}
