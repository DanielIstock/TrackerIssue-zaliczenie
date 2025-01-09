using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackerIssue.Data;
using TrackerIssue.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace TrackerIssue.Pages.Issues
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Issue> Issues { get; set; }

        public async Task OnGetAsync()
        {
            Issues = await _context.Issues
                                   .Include(i => i.Project)
                                   .Include(i => i.User)
                                   .ToListAsync();
        }
    }
}
