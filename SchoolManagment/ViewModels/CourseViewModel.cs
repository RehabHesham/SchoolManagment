using SchoolManagment.Models;

namespace SchoolManagment.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public Course course{ get; set; }

        public int? TeacherId { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
