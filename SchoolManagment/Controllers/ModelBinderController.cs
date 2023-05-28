using Microsoft.AspNetCore.Mvc;
using SchoolManagment.Models;

namespace SchoolManagment.Controllers
{
    public class ModelBinderController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult PremitiveDT(string name, int age)
        {
            return Content($"Name = {name}, Age={age}");
        }

        public IActionResult ArrayDT(string[] color)
        {
            return Content($"{string.Join(',',color)}");
        }

        public IActionResult ObjectDT(Student student)
        {
            return Content($"name = {student.Name}, id = {student.Id}");
        }

        public IActionResult CollectionDT(Dictionary<string, string> map)
        {
            return Content($"{string.Join(',', map)}");
        }
    }
}
