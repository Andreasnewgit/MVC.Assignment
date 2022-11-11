using Microsoft.AspNetCore.Mvc;

namespace MCV.Controllers
{
    public class NumberGameController : Controller
    {
        public IActionResult NumberGame()
        {
            HttpContext.Session.SetInt32(SessionKeyNumber, random.Next(1, 1000));
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
