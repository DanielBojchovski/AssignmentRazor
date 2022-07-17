using System.ComponentModel.DataAnnotations;

namespace AssignmentRazor.Models
{
    public class Assignment
    {
        public uint Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(300)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(300)]
        public string EmployeesWorkingOnAssignment { get; set; } = string.Empty;
        public AssignmentType AssignmentType { get; set; }
        public Priority Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }
}
