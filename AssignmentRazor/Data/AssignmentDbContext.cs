using AssignmentRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentRazor.Data
{
    public class AssignmentDbContext : DbContext
    {
        public AssignmentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
    }
}
