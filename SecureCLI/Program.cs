using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SecureCLI
{
    public class Program
    {

        private const string URL = "https://localhost:5001/SearchSecureAPI/secure";
        private const string urlParameters = "?domain=";

        static void Main(string[] args)
        {
            int numberOfArguments = args.Length;


        if (numberOfArguments > 0)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters + args[0]).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var data = response.Content.ReadAsAsync<DataObject>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                
                Console.WriteLine("{0}", data.message);
                
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();

        }
        else
        {
            Console.WriteLine("No arguments were passed.");
        }

        Console.ReadLine(); // Keep the console open.
        }
    }

    public class DataObject
    {
        public bool isSecure { get; set; }

        public string message { get; set; }
    }
}
