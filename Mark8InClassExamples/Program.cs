using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            // recursive solution (as opposed to iterative)
            return n * Factorial(n - 1);

            // e.g.
            // 5! = 5 * 4!
            //  4! = 4 * 3!
            //   3! = 3 * 2!
            //    2! = 2 * 1!
            //     1! = 1 * 0!
            //      0! = 1 (because math)
        }
    }
}
