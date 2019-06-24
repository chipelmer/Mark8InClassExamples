using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main()
        {
            string name = AskQuestion("What is your name?");
            string favoriteColor = AskQuestion("What is your favorite color?");
            string favoriteAnimal = AskQuestion("What is your favorite animal?");
            Console.WriteLine("Hey, " + name + ".");
            Console.WriteLine("Your favorite color is " + favoriteColor);
            Console.WriteLine("Your favorite animal is " + favoriteAnimal);
        }

        static string AskQuestion(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();
            }

            return response;
        }
    }
}
