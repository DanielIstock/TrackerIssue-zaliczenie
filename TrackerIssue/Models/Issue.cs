using System.ComponentModel.DataAnnotations;

namespace TrackerIssue.Models
{
    public class Issue
    {
        public int Id { get; set; } 
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Priority Priority { get; set; }

        public IssueStatus Status { get; set; }

        public int? ProjectId { get; set; }
        public Project Project { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
