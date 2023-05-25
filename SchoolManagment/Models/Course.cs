using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public int? FullMark { get; set; }

        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual List<StudnetCourse>? CourseStudents { get; set; }
    }
}
