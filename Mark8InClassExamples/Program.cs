using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static int AddNumbersFrom1ToN(int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total = total + i;
            }
            return total;
        }

        static void AskNumericQuestionThenDisplayTotal(string question)
        {
            Console.WriteLine(question);
            string responseAsAString = Console.ReadLine();
            int response = int.Parse(responseAsAString);

            // Calling another method that we created
            int total = AddNumbersFrom1ToN(response);

            Console.WriteLine("If you add all the numbers from 1-" + response + ", the total is " + total);
        }

        static void Main()
        {
            // Calling a method that then calls another method
            AskNumericQuestionThenDisplayTotal("What is your favorite number?");
            AskNumericQuestionThenDisplayTotal("What is your favorite year?");
        }
    }
}
