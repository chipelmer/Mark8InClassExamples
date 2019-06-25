using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 4, 7, 12, 5, 8 };

            // This example string array is not used later in the code
            string[] names = { "Zee", "Brandon", "Daniel", "Josh", "Chip", "Charlotte" };

            int total1 = SumNumbers(values);

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = 2;
            }

            int total2 = SumNumbers(values);

            Console.WriteLine(total1);
            Console.WriteLine(total2);
        }

        static int SumNumbers(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total = total + nums[i];
            }

            // Could do:
            //foreach (int number in nums)
            //{
            //    total += number;
            //}

            return total;
        }
    }
}
