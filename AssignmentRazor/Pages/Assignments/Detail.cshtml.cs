using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AssignmentRazor.Data;
using AssignmentRazor.Models;

namespace AssignmentRazor.Pages.Assignments
{
    public class DetailModel : PageModel
    {
        private readonly AssignmentDbContext _context;

        public DetailModel(AssignmentDbContext context) => _context = context;

        public async void OnGet(uint id) => Assignment = await _context.Assignments.FindAsync(id);

        public async void OnGetResolve(uint id)
        {
            var assignmentToUpdate = _context.Assignments.SingleOrDefault(i => i.Id == id);
            if (assignmentToUpdate == null) return;

            assignmentToUpdate.Completed = DateTime.Now;
            _context.Update(assignmentToUpdate);
            await _context.SaveChangesAsync();
        }

        public Assignment? Assignment { get; private set; }
    }
}
