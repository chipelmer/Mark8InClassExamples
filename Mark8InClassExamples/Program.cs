using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game!");

            int max = GetIntegerFromUser("What max range would you like?");

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, max + 1);

            int score = 0;
            int guess;
            do
            {
                Console.ResetColor();

                Console.WriteLine("Your current score is " + score);
                guess = GetIntegerFromUser("Please guess a number between 1-" + max + ":");

                if (guess > secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too high, loser!");
                    score += 1;
                }
                else if (guess < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too low, loser.");
                    score += 1;
                }

            } while (guess != secretNumber);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You got it!");
            Console.WriteLine("Your final score was " + score);

        }
    }
}
