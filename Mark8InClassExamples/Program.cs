using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is calling the overload that accepts 2 integers
            int result1 = Add(2, 3);

            // This is calling the overload that accepts 3 integers
            int result2 = Add(12, 20, 9);
        }


        // There are 2 overloads for the Add method
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
