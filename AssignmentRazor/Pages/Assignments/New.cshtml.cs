using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AssignmentRazor.Data;
using AssignmentRazor.Models;

namespace AssignmentRazor.Pages.Assignments
{
    public class NewModel : PageModel
    {
        private readonly AssignmentDbContext _context;

        public NewModel(AssignmentDbContext context) => _context = context;

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            Assignment.Created = DateTime.Now;
            await _context.Assignments.AddAsync(Assignment);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }

        [BindProperty]
        public Assignment Assignment { get; set; }
    }
}
