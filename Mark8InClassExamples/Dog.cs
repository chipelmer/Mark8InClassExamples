using System;

namespace Mark8InClassExamples
{
    class Dog
    {
        public Dog(string dogName)
        {
            Name = dogName;
            Console.WriteLine("Instantiating a dog...");
        }

        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public void Speak()
        {
            Console.WriteLine("Ruff! My name is " + Name + "!");
        }
    }
}
