using System;

namespace Mark8InClassExamples
{
    class Human
    {
        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name + ".");
        }
    }
}
