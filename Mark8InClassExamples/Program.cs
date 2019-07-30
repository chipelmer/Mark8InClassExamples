using System;
using System.Linq;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages1 = { 4, 5, 7, 6, 5, 3, 34, 6, 7, 7, 6, 5, 4, 3, 4, 56, 65, 2, 13, 89 };

            // The integer array class does not have a sum method
            // Sum is an extension method from the System.Linq namespace
            int sumOfAges = ages1.Sum();

            // Within the parens would be read as "x such that x is less than or equal to 17"
            // Since Where() returns an IEnumerable, but we want to store the result as an array,
            // we have to call ToArray() on the returned value from Where()
            int[] minors = ages1.Where(x => x <= 17).ToArray();

            int sumOfEvenAges = ages1.Where(x => x % 2 == 0).Sum();

            // Extension methods can be discerned from Intellisense because they have
            // a black arrow pointing down to the left of the method's name


            string[] names = { "a", "ab", "abc", "b", "bc", "bcd", "c", "cd", "cde", "jimmy" };

            // Get only the names with a length that is less than 2
            string[] shortNames = names.Where(x => x.Length < 2).ToArray();

            // Get only names that start with a uppercase or lowercase C
            string[] cNames = names.Where(x => x[0] == 'c' || x[0] == 'C').ToArray();

            // Get only names that start with an uppercase letter
            string[] capitalFirstLetterNames = names.Where(x => char.IsUpper(x[0])).ToArray();

            // Get an array with all the elements of names converted to uppercase
            string[] uppercasedNames = names.Select(x => x = x.ToUpper()).ToArray();
        }
    }
}
