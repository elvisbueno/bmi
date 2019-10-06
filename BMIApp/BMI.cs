using System;
namespace BMIApp
{
    public class BMI
    {
        public static double weight;
        public static double height;
        public static int number = 703;



        public static void GetBmi()
        {

            Console.Write("Enter your weight in pounds: ");

            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.Write("Invalid input, try again. Enter your weight in pounds please: ");

            }

            Console.Write("\nEnter your height in inches: ");

            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Invalid input, try again. Enter your height in inches please: ");

            }


            double results = weight * number / Math.Pow(height, 2);
            if (results <= 18.5)
            {
                Console.WriteLine("\nYour BMI is " + Math.Round(results) + " and it is low. Your not getting enough food.");
                Console.WriteLine("\n---------------------------[process completed]------------------------");
            }
            else if (results <= 24.9 && results >= 18.5)
            {
                Console.WriteLine("\nYour BMI is " + Math.Round(results) + " and it is normal for your height and weigth.");
                Console.WriteLine("\n---------------------------[process completed]-------------------------");
            }
            else if (results <= 29.9 && results >= 25)
            {
                Console.WriteLine("\nYour BMI is " + Math.Round(results) + "." + " Your OVERWEIGHT. You should try and loose some weight for your health.");
                Console.WriteLine("\n---------------------------[process completed]--------------------------");
            }
            else
            {
                Console.WriteLine("\nYour BMI is " + Math.Round(results) + " and your at an obesity level. Seek medical attention.");
                Console.WriteLine("\n----------------------------[process completed]-------------------------");
            }






        }
    }
}
