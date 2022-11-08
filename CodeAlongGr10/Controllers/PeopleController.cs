using Microsoft.AspNetCore.Mvc;

namespace MCV.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult PeopleIndex()
        {
            return View();
        }
    }
}
