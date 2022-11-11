using MCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace MCV.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            if (PersonViewModel.listOfPeople.Count == 0)
                PersonViewModel.GeneratePeople();

            PersonViewModel vm = new PersonViewModel();

            vm.tempList = PersonViewModel.listOfPeople;
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {           
            if (person != null)
            {
                person.Id = Guid.NewGuid().ToString();
                PersonViewModel.listOfPeople.Add(person);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var personToDelete = PersonViewModel.listOfPeople.First(x => x.Id == id);
            if(personToDelete != null)
            {
                PersonViewModel.listOfPeople.Remove(personToDelete);
            }
            return RedirectToAction("Index");
        }


        public IActionResult PartialIndex()
        {
            if (PersonViewModel.listOfPeople.Count == 0)
                PersonViewModel.GeneratePeople();

            PersonViewModel vm = new PersonViewModel();

            vm.tempList = PersonViewModel.listOfPeople;
            return View(vm);
        }

    }
}
