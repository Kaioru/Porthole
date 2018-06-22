using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Porthole.Models
{
	public partial class DatabaseContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder
				.UseSqlServer(ConfigurationManager.ConnectionStrings["main"].ToString());
        }      

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
			modelBuilder.Entity<StudentSkillSet>()
			            .HasKey(m => new { m.StudentID, m.SkillSetID });

			modelBuilder.Entity<ProjectMember>()
			            .HasKey(m => new { m.StudentID, m.ProjectID });
        }

		public virtual DbSet<Student> Student { get; set; }
		public virtual DbSet<Mentor> Mentor { get; set; }
		public virtual DbSet<Parent> Parent { get; set; }
		public virtual DbSet<Project> Project { get; set; }
		public virtual DbSet<SkillSet> SkillSet { get; set; }
		public virtual DbSet<Suggestion> Suggestion { get; set; }
		public virtual DbSet<ViewingRequest> Request { get; set; }
    }
}
