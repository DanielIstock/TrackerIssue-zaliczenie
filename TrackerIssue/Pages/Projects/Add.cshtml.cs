using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrackerIssue.Data;
using TrackerIssue.Models;

namespace TrackerIssue.Pages.Projects
{

    [Authorize(Roles = "Admin")]
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Project Project { get; set; }

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

            Project.CreatedAt = DateTime.Now;
            _context.Projects.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Projects/Index");
        }
    }
}
