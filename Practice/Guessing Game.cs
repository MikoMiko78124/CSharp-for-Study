using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Welcome to Guessing Game!");
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int tryguess = 5;
            Console.WriteLine("Guess a number between 1 and 100:");
            userGuess = Convert.ToInt32(Console.ReadLine());
            
            while (tryguess > 0 && userGuess != numberToGuess)
            {
                if(tryguess > 0)
                {
                    Console.WriteLine($"You have {tryguess} tries left.");
                }
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again:");
                }
                else
                {
                    Console.WriteLine("Too high! Try again:");
                }
                userGuess = Convert.ToInt32(Console.ReadLine());
                tryguess--;

            }
            if (userGuess == numberToGuess)
            {
                Console.WriteLine("Congratulations! You guessed the number.");
            }
            else
            {
                Console.WriteLine($"You've run out of tries. The number was {numberToGuess}.");
            }
            }
            catch
            {
               Console.WriteLine("Error");
            }
        }
    }
}