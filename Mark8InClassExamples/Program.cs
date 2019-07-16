using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite mammal?");
            string response = Console.ReadLine();

            // ternary operator  ---  conditional ? true_option : false_option
            string message = (response == "dog") ? "Awesome!" : "Ok then";

            // the ternary above does what this if statement would do
            //if (response == "dog")
            //{
            //    message = "Awesome!";
            //}
            //else
            //{
            //    message = "Ok then";
            //}

            Console.WriteLine(message);
        }
    }
}
