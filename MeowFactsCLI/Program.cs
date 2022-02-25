using Newtonsoft.Json;
using System.Net;


namespace MeowFacts
{
    class Program
    {
        
        // MeowFacts URL
        private const string API = "https://meowfacts.herokuapp.com";
        static void Main(string[] args)
        {
            // Create the http WebClient to GET API call
            WebClient client = new WebClient();

            // Create string to store Json data
            string jsonString;

            // GET the json data, store in jsonString
            jsonString = client.DownloadString(API);

            // Convert Json into C# Class
            MeowFactsAPILibrary.MeowFacts MeowFact = JsonConvert.DeserializeObject<MeowFactsAPILibrary.MeowFacts>(jsonString);

            // For debugging, display raw Json data
            // Console.WriteLine(jsonString);

            // MeowFact is displayed as properties of MeowFact object
            Console.WriteLine($"{MeowFact.Data[0]}");

            // Pause the program
            Console.ReadLine();
        }
    }
}

