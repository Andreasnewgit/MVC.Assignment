using CodeAlongGr10.Models;
using MCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace MCV.Controllers
{
    public class NumberGameController : Controller
    {

        public IActionResult Index()
        {

            return RedirectToAction("NumberGuesser");
        }

        public IActionResult NumberGuesser()
        {

            HttpContext.Session.SetInt32("NumberToGuess", new GuessingGameModel().GetNumber());
            return View();
        }
        [HttpPost]
        public IActionResult NumberGuesser(int GuessedNumber)
        {
            GuessingGameModel.CheckGuess(HttpContext.Session, GuessedNumber, this);
            return View();
        }
    }
}
