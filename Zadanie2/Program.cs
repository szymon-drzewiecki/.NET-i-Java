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
            var context = new KlasaGlowna();

            var databaseName = context.Database.Connection.Database;
            Console.WriteLine(databaseName);
           //Database.Delete(databaseName);

            Console.WriteLine("Enter day:");
            string day = Console.ReadLine();
            Console.WriteLine("Enter month:");
            string month = Console.ReadLine();
            Console.WriteLine("Enter year:");
            string year = Console.ReadLine();
            string date_of_data = year.ToString() + "-" + month.ToString() + "-" + day.ToString();

            var checkIfExists = new List<Dane>();
            checkIfExists = context.ZestawyDanych.Where(x => x.date == date_of_data).ToList<Dane>();
            if (checkIfExists.Count != 0)
            {
                Console.WriteLine("Hej");
                Console.Read();
                Environment.Exit(0);
            }


            string call = "http://openexchangerates.org/api/historical/" + date_of_data +".json?app_id=23e326842d4044d1a971b4fb0359c5a3";
            Task<string> Task = LoadJSON(call);
            string json = Task.Result;
            Dane obiektKlasy = JsonConvert.DeserializeObject<Dane>(json);
            obiektKlasy.date = date_of_data;
           // Console.WriteLine(obiektKlasy.timestamp + " " + Convert.ToString(obiektKlasy.rates.PLN) + " " + Convert.ToString(obiektKlasy.rates.BTC));
           // Console.Read();

            
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
