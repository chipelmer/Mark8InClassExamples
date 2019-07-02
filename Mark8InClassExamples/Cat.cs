using System;
using System.Collections.Generic;
using System.Text;

namespace Mark8InClassExamples
{
    public class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Meow()
        {
            Console.WriteLine("Meeeeoow!! I'm " + Name + "...");
        }
    }
}
