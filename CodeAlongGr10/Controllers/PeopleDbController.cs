using MCV.Data;
using MCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace MCV.Controllers
{
    public class PeopleDbController : Controller
    {

        readonly AppDbContext _context;

        public PeopleDbController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.PeopleData.ToList());
        }
        
        public IActionResult CreateDB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDB(PersonData person)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                person.Id = Guid.NewGuid().ToString();
                _context.PeopleData.Add(person);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
