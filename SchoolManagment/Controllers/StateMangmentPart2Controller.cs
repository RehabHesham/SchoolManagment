using Microsoft.AspNetCore.Mvc;

namespace SchoolManagment.Controllers
{
    public class StateMangmentPart2Controller : Controller
    {
        // Query String
        public IActionResult SetQueryString()
        {
            return View();
        }

        public IActionResult getQueryString(string name, int age)
        {
            return Content($"Name = {name}, Age={age}");
        }


        // TempData
        public IActionResult SetTempData()
        {
            TempData["name"] = "Ali";
            TempData["age"] = 23;
            return Content("TempData contains data");
        }

        public IActionResult GetTempData()
        {
            string name = TempData.ContainsKey("name")?TempData["name"].ToString():"Empty";
            int age = TempData.ContainsKey("age") ? int.Parse(TempData["age"].ToString()) : 0;

            return Content($"Name = {name}, Age={age}");
        }

        public IActionResult keepTempData()
        {
            string name = TempData.ContainsKey("name") ? TempData["name"].ToString() : "Empty";
            TempData.Keep("name");
            int age = TempData.ContainsKey("age") ? int.Parse(TempData["age"].ToString()) : 0;

            return Content($"Name = {name}, Age={age}");
        }

        // Cookies
        public IActionResult SetCookies()
        {
            Response.Cookies.Append("name", "ali");
            Response.Cookies.Append("age", "22");

            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(5),
            };

            Response.Cookies.Append("login", "welcome Ahmed", options);

            return Content("Cookies contain data");
        }

        public IActionResult GetCookies()
        {
            string name = Request.Cookies["name"];
            int age = int.Parse(Request.Cookies["age"]);
            return Content($"Name = {name}, Age={age}");
        }

        public IActionResult DeleteCookies()
        {
            Response.Cookies.Delete("name");
            return Content("Name cookie is deleted");
        }
    }
}
