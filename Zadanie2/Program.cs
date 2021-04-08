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

            var ifExists = new List<Dane>();
            ifExists = context.ZestawyDanych.Where(x => x.date == date_of_data).ToList<Dane>();
            if (ifExists.Count != 0)
            {
                Console.WriteLine("Hej, mamy to już w DB! :)");
                Console.WriteLine("Dane dla dnia: " + date_of_data);
                foreach (var x in ifExists)
                    Console.WriteLine("PLN: {0}", x.rates.PLN);
                Console.Read();
                Environment.Exit(0);
            }

            Console.WriteLine("Hmm... Tego w naszej bazie nie ma, pobieranko...");
            string call = "http://openexchangerates.org/api/historical/" + date_of_data +".json?app_id=23e326842d4044d1a971b4fb0359c5a3";
            Task<string> Task = LoadJSON(call);
            string json = Task.Result;
            Dane obiektKlasy = JsonConvert.DeserializeObject<Dane>(json);
            obiektKlasy.date = date_of_data;
           // Console.WriteLine(obiektKlasy.timestamp + " " + Convert.ToString(obiektKlasy.rates.PLN) + " " + Convert.ToString(obiektKlasy.rates.BTC));
           // Console.Read();

            
            context.ZestawyDanych.Add(obiektKlasy);
            context.SaveChanges();


            var justDownloaded = context.ZestawyDanych.Where(d => d.date == date_of_data).ToList<Dane>();
            Console.WriteLine("Dane dla dnia: " + date_of_data);
            // var rates = context.ZestawyDanych.SqlQuery("select * from ZestawyDanych").ToList<Dane>();
            foreach (var d in justDownloaded)
                Console.WriteLine("PLN: {0}", d.rates.PLN);
            Console.Read();
        }

        void WriteByDay(KlasaGlowna context, Dane obiektyKlasy, string date_of_data)
        {
            var justDownloaded = context.ZestawyDanych.Where(d => d.date == date_of_data).ToList<Dane>();
            Console.WriteLine("Dane dla dnia: " + date_of_data);
            foreach (var d in justDownloaded)
            {
                Console.WriteLine("PLN: {0}", d.rates.PLN);
                Console.WriteLine("EUR: {0}", d.rates.EUR);
                Console.WriteLine("BTC: {0}", d.rates.BTC);
                Console.WriteLine("COP: {0}", d.rates.COP);
            }
        }

        string WriteAll(KlasaGlowna context, Dane obiektyKlasy, string currency)
        {
            string retString = "";
            var allDownloaded = context.ZestawyDanych.SqlQuery("select * from ZestawyDanych").ToList<Dane>();
            foreach (var d in allDownloaded)
            {
                /*
                if (currency == "EUR")
                retString += d.date + "   " + "EUR:" + (d.rates.EUR).ToString();
                else if (currency == "PLN")
                    retString += d.date + "   " + "PLN:" + (d.rates.PLN).ToString();
                */

                retString = d.date + "   " + (d.rates.PLN).ToString() + Environment.NewLine;

                /*
                Console.WriteLine("Dane dla dnia: " + d.date);
                Console.WriteLine("PLN: {0}", d.rates.PLN);
                Console.WriteLine("EUR: {0}", d.rates.EUR);
                Console.WriteLine("BTC: {0}", d.rates.BTC);
                Console.WriteLine("COP: {0}", d.rates.COP);
                */
                
            }
            return retString;
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
