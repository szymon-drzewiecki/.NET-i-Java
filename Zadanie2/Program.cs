using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string call = "http://openexchangerates.org/api/historical/2021-03-25.json?app_id=23e326842d4044d1a971b4fb0359c5a3";
            Task<string> Task = LoadJSON(call);
            string json = Task.Result;
            Class1 obiektKlasy = JsonConvert.DeserializeObject<Class1>(json);
            Console.WriteLine(obiektKlasy.timestamp + " " + Convert.ToString(obiektKlasy.PLN));
            Console.Read();
        }

        static async Task<string> LoadJSON(string call)
        {
            HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(call);
            return json;
        }
    }
}
