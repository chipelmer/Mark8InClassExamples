using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main()
        {
            int numberOfAdditions = GetIntegerFromUser("How many numbers would you like to add?");

            int grandTotal = 0;
            for (int i = 0; i < numberOfAdditions; i++)
            {
                // Could do: grandTotal += GetIntegerFromUser("What is number " + (i + 1) + "?");
                int answer = GetIntegerFromUser("What is number " + (i + 1) + "?");
                grandTotal += answer; // Same as: grandTotal = grandTotal + answer;
            }

            Console.WriteLine("The total is " + grandTotal);
        }

        static int GetIntegerFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            // Could do: return int.Parse(response);
            int number = int.Parse(response);
            return number;
        }
    }
}
