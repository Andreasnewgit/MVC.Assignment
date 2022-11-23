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
        public IActionResult Create(PersonData person)
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
            var deletePerson = PersonViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            if(deletePerson != null)
            {
                PersonViewModel.listOfPeople.Remove(deletePerson);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Search(string name, string city)
        {

            PersonViewModel vm = new PersonViewModel();
            var tempList = PersonViewModel.listOfPeople;
            

            var searchResultName = PersonViewModel.listOfPeople.Where(x => x.Name == name);
            var searchResultCity = PersonViewModel.listOfPeople.Where(x => x.City == city);


            foreach (var name_ in searchResultName)
            {
                tempList.Add(name_);
            }

            foreach (var city_ in searchResultCity)
            {
                tempList.Add(city_);
            }


            return RedirectToAction("Index");
        }

    }
}
