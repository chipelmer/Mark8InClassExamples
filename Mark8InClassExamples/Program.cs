using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is not using all best practices, but it demonstrates making an API
            // call and parsing a JSON response

            string url = "https://api.chucknorris.io/jokes/random";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;

            // This manual way of pulling out the text of the joke is not good or reliable:
            //int jokeStartIndex = response.IndexOf("value") + 8;
            //int jokeLength = response.Length - jokeStartIndex - 2;
            //string joke = response.Substring(jokeStartIndex, jokeLength);

            string joke2 = JObject.Parse(response).GetValue("value").ToString();

            Console.WriteLine(joke2);
        }
    }
}
