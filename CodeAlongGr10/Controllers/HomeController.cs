using MCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //if (PersonViewModel.listOfPeople.Count == 0)
            //    PersonViewModel.GeneratePeople();

            //PersonViewModel vm = new PersonViewModel();

            //vm.tempList = PersonViewModel.listOfPeople;
            //return View(vm);
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


    }
}
