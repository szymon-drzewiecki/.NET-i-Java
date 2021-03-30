using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data.Entity;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string call = "http://openexchangerates.org/api/historical/2021-03-25.json?app_id=23e326842d4044d1a971b4fb0359c5a3";
            Task<string> Task = LoadJSON(call);
            string json = Task.Result;
            Dane obiektKlasy = JsonConvert.DeserializeObject<Dane>(json);
           // Console.WriteLine(obiektKlasy.timestamp + " " + Convert.ToString(obiektKlasy.rates.PLN) + " " + Convert.ToString(obiektKlasy.rates.BTC));
           // Console.Read();

            var context = new KlasaGlowna();
            context.ZestawyDanych.Add(obiektKlasy);
            context.SaveChanges();

            var dane = context.ZestawyDanych.Where(d => d.rates.PLN > 0).ToList<Dane>();

            // var rates = context.ZestawyDanych.SqlQuery("select * from ZestawyDanych").ToList<Dane>();


            foreach (var d in dane)
                Console.WriteLine("PLN: {0}", d.rates.PLN);
            Console.Read();
        }

        static async Task<string> LoadJSON(string call)
        {
            HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(call);
            return json;
        }

        public class KlasaGlowna: DbContext
        {
            public virtual DbSet<Dane> ZestawyDanych { get; set; }
        }




    }
}
