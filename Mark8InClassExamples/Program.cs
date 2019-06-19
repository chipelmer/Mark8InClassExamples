using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating variables with different types
            string firstName = "Chip";
            char firstLetterOfFirstName = 'C';
            int favoriteNumber = 2;
            double pi = 3.14;
            bool isMarried = true;

            // an if-statement that checks if the value of `favoriteNumber` is greather than 0
            if (favoriteNumber > 0)
            {
                // this will only run if the conditional was true (favoriteNumber > 0)
                Console.WriteLine("You have a positive outlook!");
            }
        }
    }
}
