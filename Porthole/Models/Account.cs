using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Porthole.Models
{
	public interface Account
    {
        string EmailAddress { get; set; }
        string Password { get; set; }
    }
}
