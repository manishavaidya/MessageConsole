using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MessageConsole
{
    public class ConsumeAPI
    {
       public async Task HelloWorldAPIGet(HttpClient myConsole, int id)
        {
            using (myConsole)
            {
                HttpResponseMessage res = await myConsole.GetAsync("api/HelloWorld/" + id);
                if (res.IsSuccessStatusCode) // If Success
                {
                    var result = await res.Content.ReadAsAsync<string>();
                    Console.WriteLine( "{0}\n", result);
                    Console.ReadLine();
                }
                else //incorrect input
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect input. Please try again");
                    Console.ReadLine();
                }
            }
        }
    }
}
