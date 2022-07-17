using AssignmentRazor.Data;
using AssignmentRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AssignmentRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AssignmentDbContext _context;
        public IndexModel(AssignmentDbContext context) => _context = context;

        public async void OnGet()
        {
            Assignments = await _context.Assignments.Where(i => i.Completed == null)
                .OrderByDescending(i => i.Created)
                .ToListAsync();
        }

        public IEnumerable<Assignment> Assignments { get; set; } = Enumerable.Empty<Assignment>();
    }
}