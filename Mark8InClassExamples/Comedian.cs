using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Mark8InClassExamples
{
    // The Comedian class is supposed to conform to the IPerform interface
    class Comedian : IPerform
    {
        public void Perform()
        {
            Console.WriteLine("Welcome! Here's a joke!");
            TellChuckNorrisJoke();
            Console.WriteLine("You've been a great audience, goodnight!");
        }

        public void TellChuckNorrisJoke()
        {
            // This is not using all best practices, but it demonstrates making an API
            // call and parsing a JSON response

            string url = "https://api.chucknorris.io/jokes/random";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            string joke = JObject.Parse(response).GetValue("value").ToString();

            Console.WriteLine(joke);
        }
    }
}
