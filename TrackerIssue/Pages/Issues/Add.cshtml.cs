using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrackerIssue.Data;
using TrackerIssue.Models;

namespace TrackerIssue.Pages.Issues
{
    [Authorize]
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Issue Issue { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Issue.Status = IssueStatus.Open;
            _context.Issues.Add(Issue);      
            await _context.SaveChangesAsync(); 

            return RedirectToPage("/Issues/Index"); 
        }

    }
}
