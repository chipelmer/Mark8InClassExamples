using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game!");
            Console.WriteLine("What maximum value would you like to use?");
            string strMax = Console.ReadLine();
            int max = int.Parse(strMax);

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, max + 1);

            int guess;
            do
            {
                Console.ResetColor();
                // Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please guess a number between 1-" + max + ":");

                string strGuess = Console.ReadLine();
                guess = int.Parse(strGuess);
                // Could do: int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You got it!");
                }
                else if (guess > secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too high, loser!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too low, loser.");
                }

            } while (guess != secretNumber);
        }
    }
}
