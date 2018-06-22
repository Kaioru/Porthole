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

		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<Mentor> Mentors { get; set; }
		public virtual DbSet<Parent> Parents { get; set; }
		public virtual DbSet<Project> Projects { get; set; }
		public virtual DbSet<SkillSet> SkillSets { get; set; }
		public virtual DbSet<Suggestion> Suggestions { get; set; }
		public virtual DbSet<ViewingRequest> Requests { get; set; }
    }
}
