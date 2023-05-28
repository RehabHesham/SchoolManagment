using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagment.Models;
using SchoolManagment.ViewModels;

namespace SchoolManagment.Controllers
{
    public class CourseController : Controller
    {
        SchoolContext context;
        public CourseController()
        {
            context = new SchoolContext();
        }
        public IActionResult Index()
        {
            List<Course> courses = context.Courses.ToList();
            return View(courses);
        }

        public IActionResult Details(int id) {
        Course course = context.Courses.SingleOrDefault(c=>c.Id == id); ;
            return View(course);
        }

        public IActionResult Add() {

            List<Teacher> teachers = context.Teachers.ToList();
            ViewBag.teachers = teachers;
            return View();
        }

        [HttpPost]
        public IActionResult AddDB(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Course course = context.Courses.SingleOrDefault(course => course.Id == id);
            CourseViewModel courseView = new CourseViewModel()
            {
                Id=course.Id,
                Name =course.Name,
                Description=course.Description,
                Duration = course.Duration,
                TeacherId=course.TeacherId,
                Teachers=context.Teachers.ToList()
            };
            return View(courseView);
        }

        [HttpPost]
        public IActionResult Edit(Course course)
        {
            //Course OldCourse = context.Courses.SingleOrDefault(c => c.Id == course.id);


            //OldCourse.Id = course.Id;
            //OldCourse.Name = course.Name;
            //OldCourse.Description = course.Description;
            //OldCourse.Duration = course.Duration;

            context.Courses.Update(course);

            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Course course = context.Courses.SingleOrDefault(c => c.Id == id);
            context.Courses.Remove(course);
            context.SaveChanges();
            return RedirectToAction(nameof(Index)); 
        }
    }
}
