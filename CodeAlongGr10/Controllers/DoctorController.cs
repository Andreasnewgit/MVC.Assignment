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

       
  

        public IActionResult NumberGame()
        {
            HttpContext.Session.SetInt32(SessionKeyNumber, random.Next(1, 101));
            return View();
        }


        readonly Random random = new Random();
        private const string SessionKeyNumber = "_Number";
        private const string SessionKeyGuesses = "_Guesses";


        [HttpPost]
        public IActionResult NumberGame(int? input)
        {
            if (input == null)
            {
                ViewBag.Message = "Please enter a number";
                return View();
            }

            int? numberToGuess = HttpContext.Session.GetInt32(SessionKeyNumber);
            int? guesses = HttpContext.Session.GetInt32(SessionKeyGuesses);
            guesses++;

            if (guesses != null) HttpContext.Session.SetInt32(SessionKeyGuesses, (int)guesses);
            else HttpContext.Session.SetInt32(SessionKeyGuesses, 1);

            if (input == numberToGuess)
            {
                ViewBag.Message = $"You guessed the number in {guesses} guesses, the answer was {numberToGuess} \n" +
                    $"game will now reset for a new number";
                ResetGame();

            }
            else if (input > numberToGuess)
            {
                ViewBag.Message = $"Your guess is too high. You have guessed {guesses} times";
            }
            else
            {
                ViewBag.Message = $"Your guess it too low. You have guessed {guesses} times";
            }


            return View();

        }

        private void ResetGame()
        {
            HttpContext.Session.SetInt32(SessionKeyNumber, random.Next(1, 1000));
            HttpContext.Session.SetInt32(SessionKeyGuesses, 0);
        }
    }
}
