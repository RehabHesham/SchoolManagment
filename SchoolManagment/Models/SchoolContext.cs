using Microsoft.EntityFrameworkCore;

namespace SchoolManagment.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SchoolMange;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<StudnetCourse> StudnetCourses { get; set; }
    }
}
