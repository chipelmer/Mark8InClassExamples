
namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Comedian myComedian = new Comedian();
            Singer mySinger = new Singer();

            DoYourPerformance(myComedian);
            DoYourPerformance(mySinger);
        }

        static void DoYourPerformance(IPerform performer)
        {
            performer.Perform();
        }
    }
}
