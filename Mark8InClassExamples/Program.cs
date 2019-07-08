using System;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Comedian myComedian = new Comedian();
            myComedian.Name = "Mitch Hedberg";

            Singer mySinger = new Singer();
            mySinger.Name = "Andy Dwyer";

            // Different types being passed to the same method
            TellToIntroduce(myComedian);
            TellToIntroduce(mySinger);

            myComedian.TellChuckNorrisJoke();
        }

        // Can be passed a Comedian or a Singer because both inherit from Human
        static void TellToIntroduce(Human myHuman)
        {
            myHuman.Introduce();
        }
    }
}
