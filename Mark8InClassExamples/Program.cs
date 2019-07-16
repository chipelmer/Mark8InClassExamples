using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            // string concatenation (a good vocab word)
            string greeting1 = "It's nice to meet you, " + firstName + " " + lastName + "!";

            // string interpolation
            string greeting2 = $"It's nice to meet you, {firstName} {lastName}!";

            // string.Format - older way, mostly replaced by string interpolation now
            string greeting3 = string.Format("It's nice to meet you, {0} {1}!", firstName, lastName);

            // all 3 results are the same
            Console.WriteLine(greeting1);
            Console.WriteLine(greeting2);
            Console.WriteLine(greeting3);
        }
    }
}
