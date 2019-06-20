using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            string userResponse = "no";
            while (userResponse != "yes")
            {
                Console.WriteLine("Please say yes.");
                userResponse = Console.ReadLine();
            }


            // do-while
            int numberForDoWhileLoop = 99;
            do
            {
                Console.WriteLine("Hello");
            } while (numberForDoWhileLoop < 0);


            // for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            // foreach
            string[] names = { "Chip", "Zee", "Daniel", "Brandon" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
