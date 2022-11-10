using CodeAlongGr10.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr10.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckAge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckAge(int input)
        {
            ViewBag.Result = CheckTemperatureModel.CheckHypothermia(input);
            ViewBag.Result = CheckTemperatureModel.CheckFever(input);
            return View();

        }

   
        public IActionResult SetSession()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetSession(string input)
        {
            if(input !=null)
            {
                CookieOptions options = new();
                options.Expires = DateTime.Now.AddMinutes(5);
                HttpContext.Response.Cookies.Append("Cookie", input, options);
                HttpContext.Session.SetString("Session", input);
                ViewBag.Message = "Session has been set";
            }
            return View();
        }
        public IActionResult GetSession()
        {
            ViewBag.Session = HttpContext.Session.GetString("Session");
            ViewBag.Cookie = HttpContext.Request.Cookies["Cookie"];
            return View();
        }
    }
}
