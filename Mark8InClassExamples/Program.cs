using System.Linq; // full of extension methods

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 7, 3, 7, 2, 1 };
            int total = numbers.Sum(); // Sum() is an extension method in the System.Linq namespace
                                       // Sum() is not a method of the int[] class itself

            int x = 10;

            // The int class does not have a Multiply method
            // Multiply() is an extension method that we wrote below
            int y = x.Multiply(99);

            // GetLastCharacter() is an extension method that we wrote below
            string lastLetter = "Hello".GetLastCharacter();
        }
    }

    static class ExtensionMethods
    {
        public static int Multiply(this int number, int multiplyBy)
        {
            return number * multiplyBy;
        }

        public static string GetLastCharacter(this string str)
        {
            return str[str.Length - 1].ToString();
        }
    }
}
