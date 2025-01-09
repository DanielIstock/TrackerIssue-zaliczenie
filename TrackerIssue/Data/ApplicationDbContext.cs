using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TrackerIssue.Models;

namespace TrackerIssue.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Login = "admin", Password = "admin123", Role = "Admin" },
                new User { Id = 2, Login = "user", Password = "user123", Role = "User" }
            );
        }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Issue> Issues { get; set; }
    }
}
