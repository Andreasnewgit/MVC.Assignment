using Microsoft.AspNetCore.Mvc;

namespace MCV.Models
{
    public class GuessingGameModel
    {
        private static int randomNumber;
        private Random random = new Random();
        private const int GuessTracker = 0;     

        public GuessingGameModel()
        {
            randomNumber = random.Next(1, 101);
        }
        public int GetNumber()
        {
            return randomNumber;
        }

        public static void CheckGuess(ISession session, int GuessedNumber, Controller con)
        {
           
            if (GuessedNumber == null)
            {
                con.ViewBag.Message = "Please use a number";
                return;
            }

            if (GuessedNumber == session.GetInt32("NumberToGuess"))
            {
                con.ViewBag.Message = $"The answer was {session.GetInt32("NumberToGuess")} the number have been reset for a new game";

                // Resets it by calling a new number
                session.SetInt32("NumberToGuess", new GuessingGameModel().GetNumber());               
            }

            else if (GuessedNumber > session.GetInt32("NumberToGuess"))
            {
                con.ViewBag.Message = $"You guessed too high";
            }

            else if (GuessedNumber < session.GetInt32("NumberToGuess"))
            {
                con.ViewBag.Message = $"You guessed too low";
            }           
        }
    }
}

