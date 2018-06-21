using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Porthole.Models
{
	public partial class DatabaseContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["main"].ToString());
        }

		public virtual DbSet<Student> Student { get; set; }
    }
}
