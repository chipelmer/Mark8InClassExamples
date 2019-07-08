using System;

namespace Mark8InClassExamples
{
    class Singer : IPerform
    {
        public void Perform()
        {
            Console.WriteLine("Here's a new one I wrote just for y'all...");
            SingASong();
        }

        public void SingASong()
        {
            Console.WriteLine("Do re mi fa so la ti do!");
        }
    }
}
