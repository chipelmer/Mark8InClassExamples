using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pets do you have?");
            string response = Console.ReadLine();
            int numberOfPets = int.Parse(response);

            string[] petNames = new string[numberOfPets];

            for (int i = 0; i < numberOfPets; i++)
            {
                Console.WriteLine("What is the name of one of your pets?");
                string petName = Console.ReadLine();
                petNames[i] = petName;
            }

            //int j = 0;
            //while (j < numberOfPets)
            //{
            //    Console.WriteLine("What is the name of one of your pets?");
            //    string petName = Console.ReadLine();
            //    petNames[j] = petName;
            //    j++;
            //}

            //foreach (string name in petNames)
            //{
            //    Console.WriteLine("What is the name of one of your pets?");
            //    string petName = Console.ReadLine();
            //    name = petName; // not allowed by C#
            //}
        }
    }
}
