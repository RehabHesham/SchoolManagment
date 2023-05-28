using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Models;

namespace SchoolManagment.Controllers
{
    public class StudentController : Controller
    {
        SchoolContext context;
        public StudentController()
        {
            context = new SchoolContext();  
        }
        public IActionResult GetAll()
        {
            List<Student> students = context.Students.ToList();
            return View("GetAll",students);   // view name => same as action, Model => students
            //return View();   // view name => same as action, Model => null
            //return View("GetStudents",students);   // view name => GetStudents, Model => students
            //return View("GetStudents"); // view name => GetStudents, Model => null
        }

        public IActionResult Details(int id)
        {
            Student student = context.Students.SingleOrDefault(s => s.Id == id);
           
            return View(student);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddDB()
        {
            return RedirectToAction(nameof(GetAll));
        }
    }
}
