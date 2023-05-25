using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Models;
using SchoolManagment.ViewModels;

namespace SchoolManagment.Controllers
{
    public class StateManagmentP1Controller : Controller
    {
        SchoolContext db = new SchoolContext(); 
        public IActionResult Index()
        {
            Student std = db.Students.First();

            Course course = db.Courses.First();

            Teacher teacher = db.Teachers.First();
            ViewData["Course"] = course;
            ViewBag.Tech = teacher;
            return View(std);
        }

        public IActionResult TryViewModel()
        {
            studnetCourseTeacherVM vm = new()
            {
                student = db.Students.First(),
                teacher = db.Teachers.First(),
                course = db.Courses.First()
            };
            return View(vm);
        }

        public IActionResult GetStudentID(int Id)
        {
            if (Id > 0) return RedirectToAction("Details", "Student", new {id=Id});
            else return RedirectToAction("GetAll", "Student");
        }
    }
}
