using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Making 3 separate, independent variables to
            // describe a cat, which will have to be carefully
            // tracked/juggled as the program continues
            string catName = "Oscar";
            string catColor = "brown";
            int catAge = 1;


            // Making an instance of the Cat class
            // then assigning values to its properties
            Cat cat = new Cat();
            cat.Name = "Oscar";
            cat.Color = "brown";
            cat.Age = 1;
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
}
