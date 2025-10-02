using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Console.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Credits { get; set; }
        public int? InstructorId { get; set; }
    }
}
