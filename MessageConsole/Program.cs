using System;
using System.Net.Http;

namespace MessageConsole
{
    class Program
    {
        /// <summary>
        /// Using HttpClient to call WebAPI method
        /// Valid input is 1. any other input should return error message.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            HttpClient myConsole = new HttpClient();
            string apiURL = "http://localhost:6951/";
            myConsole.BaseAddress = new Uri(apiURL);
            myConsole.DefaultRequestHeaders.Accept.Clear();
            myConsole.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            int id = 1;
            ConsumeAPI api = new ConsumeAPI();
            api.HelloWorldAPIGet(myConsole, id).Wait();
        }
    }
}
