using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag<char> scrabbleLetters = new Bag<char>();
            scrabbleLetters.PutItemIntoBag('q');
            scrabbleLetters.PutItemIntoBag('j');
            scrabbleLetters.PutItemIntoBag('z');
            scrabbleLetters.PutItemIntoBag('y');
            scrabbleLetters.PutItemIntoBag('x');
            char letterFromBag = scrabbleLetters.GetItemFromBag();
            Console.WriteLine(letterFromBag);
        }
    }

    class Bag<T>
    {
        private List<T> items = new List<T>();

        public void PutItemIntoBag(T item)
        {
            items.Add(item);
        }

        public T GetItemFromBag()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, items.Count);
            T randomItem = items[randomIndex];
            items.RemoveAt(randomIndex);
            return randomItem;
        }
    }
}
