using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myExampleDog = new Dog("Spot");

            // This line isn't needed because the Constructor
            // is handling assigning the name of the new dog
            // myExampleDog.Name = "Spot";

            myExampleDog.Speak();
        }
    }
}
