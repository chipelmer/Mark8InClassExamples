using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you have any pets?");
            string response = Console.ReadLine();

            List<string> petNames = new List<string>();
            List<string> affirmativeResponses = new List<string>() { "y", "yes", "yeah", "yep", "uh huh" };

            while (affirmativeResponses.Contains(response.ToLower()) == true)
            {
                Console.WriteLine("What is the name of one of your pets?");
                string petName = Console.ReadLine();
                petNames.Add(petName);

                Console.WriteLine("Do you have any more pets?");
                response = Console.ReadLine();
            }
        }
    }
}
