namespace CodeAlongGr10.Models
{
    public class CheckTemperatureModel

    {

        public static string CheckHypothermia(int age)
        {
            if (age <= 35)
            {
                return "You have hypothermia";
            }
            else
            {
                return CheckFever(age);
            }
        }

        public static string CheckFever(int age)
        {
            if(age >= 38)
            {
                return $"Your temperature is {age} and you have a fever";
            }

            else
            {
                return $"Your temperature is {age} and you do not have a fever";
            }
        }
    }
}
