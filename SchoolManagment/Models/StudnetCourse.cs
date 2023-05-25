using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagment.Models
{
    [PrimaryKey("StudnetId", "CourseId")]
    public class StudnetCourse
    {
        [ForeignKey("Student")]
        public int StudnetId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public int Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
