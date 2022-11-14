using MCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace MCV.Controllers
{
    public class AjaxController : Controller
    {
        
        // Placeholder
        public IActionResult Index()
        {
            if (PersonViewModel.listOfPeople.Count == 0)
                PersonViewModel.GeneratePeople();

            PersonViewModel vm = new PersonViewModel();

            vm.tempList = PersonViewModel.listOfPeople;
            return View(vm);
        }

        [HttpPost]
        public IActionResult GetDetails(string id)
        {
            Person person = PersonViewModel.listOfPeople.FirstOrDefault(x=>x.Id == id);
            return PartialView("_personPartial", person);
        }


        [HttpPost]
        public IActionResult DeletePerson(string id)
        {
            Person person = PersonViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            return PartialView("_personPartial", person);
        }


        [HttpPost]
        public IActionResult ListAllPeople()
        {
            return PartialView("_personPartial", PersonViewModel.listOfPeople);
        }


    }

}
