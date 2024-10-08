using System;//imports library
using System.ComponentModel.DataAnnotations;//imports library

namespace HILowGuessingGame//names program
{
    internal class Program//allows for classes
    {
        static void Main(string[] args)//main function. entrypoint for program
        {
            Random random = new Random();//initiates a random number
            int value = random.Next(1, 100);//sets value between 1 and 100
            int guess = 0;//initialises guess to 0
            int guessCount = 0;//initialises guesscount to 0
            Console.WriteLine("Guess the number between 1 and 100");//prompt to user
            //while loop. while conditions in brackets are met
            while (guess != value && guessCount <7)
            {
                guessCount++;//increments guesscount by 1
                guess = int.Parse(Console.ReadLine());//accepts guess and changes it into an integer

                if (guess < value)//if condition in brackets is met
                {
                    Console.WriteLine("The number is higher");//prints to screen if condition is met

                }
                else if (guess > value)//if condition in brackets is met
                {
                    Console.WriteLine("The number is lower");//prints to screen if condition is met
                }
                else if (guess == value)//if condition in brackets is met
                {
                    Console.WriteLine("You are correct");//prints to screen if condition is met
                }
            }
            Console.WriteLine("The number was " + value);//write message after game complete
            Console.WriteLine("Press any key to exit...");//prints to screen at end of program
            Console.ReadKey();//prevents console window from closing until a key is hit

        }
    }
}