using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Mark8InClassExamples
{
    // The Comedian class is inheriting from the Human class
    class Comedian : Human
    {
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
