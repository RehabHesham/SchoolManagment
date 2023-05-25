namespace SchoolManagment.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int?  Age { get; set; }
        public string? StudyYear { get; set; }
        public virtual List<StudnetCourse>? StudnetCourses { get; set; }
    }
}
