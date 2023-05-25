namespace SchoolManagment.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual List<Course>? Courses { get; set; }
    }
}
